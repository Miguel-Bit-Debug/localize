using Localize.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Localize.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("create-accoubt")]
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
            return Ok();
        }
    }
}
