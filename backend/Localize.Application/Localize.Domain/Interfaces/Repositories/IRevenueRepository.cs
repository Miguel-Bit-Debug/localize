using Localize.Domain.Models;

namespace Localize.Domain.Interfaces.Repositories
{
    public interface IRevenueRepository
    {
        Task<Revenue> GetRevenueDataByCnpj(string cnpj);
        Task SaveRevenueData(Revenue revenue);
    }
}
