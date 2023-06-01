using Appllication.Book;
using Appllication.Client;
using Microsoft.AspNetCore.Mvc;

namespace UX2.Controllers
{
    public class BookController : AbstractController
    {
        public BookController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddBookCommand command)
        {
            return await Send(command);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetOneBookQuery(id);
            return await Send(query);
        }
    }
}
