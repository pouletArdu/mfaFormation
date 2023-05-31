using Application.Client;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UX.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(AddClientCommand command)
            => Ok(await _mediator.Send(command));
    }
}