global using MediatR;
using Appllication.Client;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace UX2.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddClientCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
