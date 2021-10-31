using JobOrder.Application.Features.Queries.GetOrderLags;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobOrder.API.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IMediator mediator;

        public ReportController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("orderlags")]
        public async Task<IActionResult> GetOrderLagReport()
        {
            var request = new GetOrderLagsQuery();
            return Ok(await mediator.Send(request));
        }
    }
}
