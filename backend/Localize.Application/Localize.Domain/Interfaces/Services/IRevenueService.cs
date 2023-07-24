using Localize.Domain.Models;

namespace Localize.Domain.Interfaces.Services
{
    public interface IRevenueService
    {
        Task<Revenue> GetRevenueDataByCnpj(string id);
        Task SaveRevenueData(Revenue revenue);
    }
}
