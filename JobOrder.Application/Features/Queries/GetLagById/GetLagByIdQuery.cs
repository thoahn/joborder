using JobOrder.Application.Dtos;
using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Queries.GetLagById
{
    public class GetLagByIdQuery : IRequest<ServiceResponse<LagViewDto>>
    {
        public int Id { get; set; }
    }
}
