using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Commands.CreateLag
{
    public class CreateLagCommand : IRequest<ServiceResponse<int>>
    {
        public string LagReason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
