using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Models;
using Localize.InfraData.Data;
using Microsoft.EntityFrameworkCore;

namespace Localize.InfraData.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckAccountExists(string email)
        {
            var account = await _context.Account
                    .Where(x => x.Email == email)
                    .FirstOrDefaultAsync();

            if (account == null)
            {
                return false;
            }

            return true;
        }

        public Task CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccountByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
