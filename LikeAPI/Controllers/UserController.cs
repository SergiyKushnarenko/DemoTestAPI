using Application.Users.Commands;
using Application.Users.DTOs;
using Application.Users.Queries;
using Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LikeAPI.Controllers
{
    /// <inheritdoc />
    public class UserController : BaseController
    {
        /// <inheritdoc />
        public UserController(IMediator mediator) : base(mediator)
        {
        }



        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllUsers")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(typeof(ResponseModelBase<UserInfoDto>), 200)]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await Mediator.Send(new CreateUserQuery());

            return Ok(result.GetResponse());
        }
    }
}
