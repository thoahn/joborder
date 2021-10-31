using AutoMapper;
using JobOrder.Application.Interfaces;
using JobOrder.Application.Wrappers;
using JobOrder.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Commands.CreateOrder
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, ServiceResponse<int>>
    {
        IOrderRepository orderRepository;
        private readonly IMapper mapper;

        public CreateOrderHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;

        }
        public async Task<ServiceResponse<int>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = mapper.Map<Order>(request);
            await orderRepository.AddAsync(order);

            return new ServiceResponse<int>(order.Id);
        }
    }
}
