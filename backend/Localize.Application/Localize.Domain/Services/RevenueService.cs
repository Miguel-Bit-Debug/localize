using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Interfaces.Services;
using Localize.Domain.Models;

namespace Localize.Domain.Services
{
    public class RevenueService : IRevenueService
    {
        private readonly IRevenueRepository _repository;

        public RevenueService(IRevenueRepository repository)
        {
            _repository = repository;
        }

        public async Task<Revenue> GetRevenueDataByCnpj(string cnpj)
        {
            var revenue = await _repository.GetRevenueDataByCnpj(cnpj);
            return revenue;
        }

        public async Task SaveRevenueData(Revenue revenue)
        {
            await _repository.SaveRevenueData(revenue);
        }
    }
}
