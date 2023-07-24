using Localize.Domain.DTOs.Request;
using Localize.Domain.DTOs.Response;

namespace Localize.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<string> CreateAccount(AccountRequest request);
        Task<string> Login(LoginRequest request);
        Task DeleteAccount(string email);
        Task UpdateAccount(string email, UpdateAccountRequest request);
        Task<AccountResponse> GetAccountInfo(string email);
    }
}
