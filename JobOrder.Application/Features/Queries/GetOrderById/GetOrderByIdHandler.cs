using AutoMapper;
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

namespace JobOrder.Application.Features.Queries.GetOrderById
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, ServiceResponse<OrderViewDto>>
    {
        readonly IOrderRepository orderRepository;
        readonly IMapper mapper;

        public GetOrderByIdHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<OrderViewDto>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await orderRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<OrderViewDto>(order);
            return new ServiceResponse<OrderViewDto>(dto);
        }
    }
}
