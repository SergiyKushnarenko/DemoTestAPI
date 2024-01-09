using Application.Users.Commands;
using Application.Users.DTOs;
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
        /// Upload file for user returns link for put request
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllUsers")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ProducesResponseType(typeof(ResponseModelBase<UserInfoDto>), 200)]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await Mediator.Send(new CreateUserCommand());

            return Ok(result.GetResponse());
        }
    }
}
