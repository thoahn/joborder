using JobOrder.Application.Features.Commands.CreateLag;
using JobOrder.Application.Features.Queries.GetAllLags;
using JobOrder.Application.Features.Queries.GetLagById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOrder.API.Controllers
{   

    [Route("api/[controller]")]
    public class LagController : Controller
    {
        private readonly IMediator mediator;

        public LagController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllLagsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetLagByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CreateLagCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
