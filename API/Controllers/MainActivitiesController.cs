using System.Collections.Generic;
using System.Threading.Tasks;
using Application.MainActivities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainActivitiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MainActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<MainActivity>>> List()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}