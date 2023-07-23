using Localize.Domain.DTOs.Response;
using Localize.Domain.Models;

namespace Localize.Domain.Interfaces.Repositories
{
    public interface IRevenueRepository
    {
        Task<Revenue> GetRevenueDataById(Guid id);
        Task SaveRevenueData(Revenue revenue);
    }
}
