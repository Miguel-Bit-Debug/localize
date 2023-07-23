using Localize.Domain.DTOs.Response;

namespace Localize.Domain.Interfaces.Services
{
    public interface IRevenueService
    {
        RevenueResponse GetRevenueDataById(string id);
    }
}
