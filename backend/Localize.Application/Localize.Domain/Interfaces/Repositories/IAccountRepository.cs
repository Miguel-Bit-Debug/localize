using Localize.Domain.Models;

namespace Localize.Domain.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        Task CreateAccount(Account account);
        Task<bool> CheckAccountExists(string email);
        Task<Account> GetAccountByEmail(string email);
        Task DeleteAccount(Account account);
        Task UpdateAccount(Account account);
    }
}
