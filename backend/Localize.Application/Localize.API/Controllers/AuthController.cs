using Localize.Domain.DTOs.Request;
using Localize.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Localize.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AuthController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount([FromBody] AccountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Select(x => x.Value?.Errors).ToList());
            }

            var result = await _accountService.CreateAccount(request);

            if (string.IsNullOrEmpty(result))
            {
                return BadRequest(new { message = "Error to create account" });
            }

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Select(x => x.Value?.Errors).ToList());
            }

            var tokenLoginAuth = await _accountService.Login(request);

            if (string.IsNullOrEmpty(tokenLoginAuth))
            {
                return Unauthorized(new { message = "Email or password it's not correct" });
            }

            return Ok(new { token = tokenLoginAuth });

        }
    }
}
