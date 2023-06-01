global using MediatR;
using Appllication.Client;
using Microsoft.AspNetCore.Mvc;

namespace UX2.Controllers
{
    public class ClientController : AbstractController
    {
        public ClientController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddClientCommand command)
        {
            return await Send(command);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetOneClientQuery(id);
            return await Send(query);
        }
    }
}
