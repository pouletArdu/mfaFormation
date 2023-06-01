using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Appllication.Author;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UX2.Controllers
{
    public class AuthorController : AbstractController
    {


        public AuthorController(IMediator mediator) : base(mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddAuthorCommand command)
        {
            return await Send(command);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetOneAuthorQuery(id);
            return await Send(query);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllAuthorQuery();
            return await Send(query);
        }


    }
}