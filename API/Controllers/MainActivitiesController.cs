using System;
using System.Collections.Generic;
using System.Threading;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<MainActivity>> Details(Guid id)
        {
            return await _mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]

        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(Edit.Command command, Guid id)
        {
            command.Id = id;
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            return await _mediator.Send(new Delete.Command { Id = id });
        }
    }
}