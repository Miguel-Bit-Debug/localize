using Localize.Domain.DTOs.Request;
using Localize.Domain.Interfaces.ExternalServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Localize.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class RevenueController : ControllerBase
    {
        private readonly IRevenueExternalService _revenueExternalService;

        public RevenueController(IRevenueExternalService revenueExternalService)
        {
            _revenueExternalService = revenueExternalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRevenue([FromQuery] RevenueRequest request)
        {
            var revenue = await _revenueExternalService.GetRevenueDtaByCnpj(request.Cnpj);

            return Ok(revenue);
        }
    }
}
