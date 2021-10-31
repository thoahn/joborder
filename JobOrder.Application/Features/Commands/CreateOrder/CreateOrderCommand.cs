using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<ServiceResponse<int>>
    {
        public string OrderName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
