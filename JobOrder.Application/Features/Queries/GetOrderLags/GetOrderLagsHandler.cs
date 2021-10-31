using JobOrder.Application.Dtos;
using JobOrder.Application.Interfaces;
using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Queries.GetOrderLags
{
    public class GetOrderLagsHandler : IRequestHandler<GetOrderLagsQuery, ServiceResponse<List<OrderLagViewDto>>>
    {
        readonly IOrderRepository orderRepository;
        readonly ILagRepository lagRepository;

        public GetOrderLagsHandler(IOrderRepository orderRepository, ILagRepository lagRepository)
        {
            this.orderRepository = orderRepository;
            this.lagRepository = lagRepository;
        }


        public async Task<ServiceResponse<List<OrderLagViewDto>>> Handle(GetOrderLagsQuery request, CancellationToken cancellationToken)
        {
            List<OrderLagViewDto> orderLags = new List<OrderLagViewDto>();
            var orderCall = orderRepository.GetAllAsync();
            var lagCall = lagRepository.GetAllAsync();

            var orderList = await orderCall;
            var lagList = await lagCall;

            foreach (var order in orderList)
            {
                foreach (var lag in lagList)
                {
                    if ((lag.StartDate >= order.StartDate && lag.StartDate <= order.EndDate) || //lag starts after order started
                        (lag.EndDate >= order.StartDate && lag.EndDate <= order.EndDate) || //or lag ends before order ended
                        (lag.StartDate <= order.StartDate && lag.EndDate >= order.EndDate)) //or lag starts before order started and ends after order ended
                    {
                        //lag duration dates for current order
                        var lagDurationStartDate = lag.StartDate < order.StartDate ? order.StartDate : lag.StartDate;
                        var lagDurationEndDate = lag.EndDate > order.EndDate ? order.EndDate : lag.EndDate;

                        
                        orderLags.Add(new OrderLagViewDto
                        {
                            OrderName = order.OrderName,
                            LagReason = lag.LagReason,
                            LagDuration = (lagDurationEndDate - lagDurationStartDate).TotalMinutes
                        });
                    }
                }
            }

            //grouping for lag durations for each order and each lag reason
            var orderLagsWithDuration = 
                (from o in orderLags
                 group o by new { o.OrderName, o.LagReason } into g
                 select new OrderLagViewDto { 
                     OrderName = g.Key.OrderName, 
                     LagReason = g.Key.LagReason, 
                     LagDuration = g.Sum(x => x.LagDuration) })
                 .ToList();

            return new ServiceResponse<List<OrderLagViewDto>>(orderLagsWithDuration);
        }
    }
}
