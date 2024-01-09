using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LikeAPI.Controllers
{
    /// <inheritdoc />
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public abstract class BaseController : Controller
    {
#pragma warning disable CS1591
        protected readonly IMediator Mediator;
#pragma warning restore CS1591

        /// <inheritdoc />
        protected BaseController(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
