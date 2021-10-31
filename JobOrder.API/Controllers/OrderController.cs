using JobOrder.Application.Features.Commands.CreateOrder;
using JobOrder.Application.Features.Queries.GetAllOrders;
using JobOrder.Application.Features.Queries.GetOrderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOrder.API.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllOrdersQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetOrderByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CreateOrderCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
