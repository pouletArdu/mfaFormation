using Appllication.Commons.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace UX2.Controllers
{
    [Route("api/[controller]")]
    public abstract class AbstractController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AbstractController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> Send<T>(IRequest<T> request)
        {
            try
            {
                return Ok(await _mediator.Send(request));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors.Select(x => x.Value));
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
