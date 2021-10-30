using AutoMapper;
using JobOrder.Application.Dtos;
using JobOrder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Order, OrderViewDto>().ReverseMap();

            CreateMap<Lag, LagViewDto>().ReverseMap();
        }
    }
}
