using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Models;
using Localize.InfraData.Data;
using Microsoft.EntityFrameworkCore;

namespace Localize.InfraData.Repositories
{
    public class RevenueRepository : IRevenueRepository
    {
        private readonly AppDbContext _appDbContext;

        public RevenueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Revenue> GetRevenueDataById(Guid id)
        {
            var revenue = await _appDbContext.Revenue.Where(x => x.Id == id).FirstOrDefaultAsync();
            return revenue;
        }

        public async Task SaveRevenueData(Revenue revenue)
        {
            await _appDbContext.AddAsync(revenue);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
