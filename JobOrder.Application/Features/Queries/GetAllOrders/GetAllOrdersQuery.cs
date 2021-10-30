using JobOrder.Application.Dtos;
using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Queries.GetAllOrders
{
    public class GetAllOrdersQuery : IRequest<ServiceResponse<List<OrderViewDto>>>
    {
    }
}
