using AutoMapper;
using JobOrder.Application.Dtos;
using JobOrder.Application.Features.Commands.CreateLag;
using JobOrder.Application.Features.Commands.CreateOrder;
using JobOrder.Core.Entities;

namespace JobOrder.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Order, OrderViewDto>().ReverseMap();

            CreateMap<Lag, LagViewDto>().ReverseMap();

            CreateMap<Order, CreateOrderCommand>().ReverseMap();

            CreateMap<Lag, CreateLagCommand>().ReverseMap();
        }
    }
}
