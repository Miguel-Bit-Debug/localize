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
            var account = await _context.Contas
                    .Where(x => x.Email == email)
                    .FirstOrDefaultAsync();

            if (account == null)
            {
                return false;
            }

            return true;
        }

        public async Task CreateAccount(Account account)
        {
            await _context.AddAsync(account);
            await _context.SaveChangesAsync();
        }

        public async Task<Account> GetAccountByEmail(string email)
        {
            var account = await _context.Contas
                .Where(x => x.Email == email)
                .FirstOrDefaultAsync();

            return account;
        }
    }
}
