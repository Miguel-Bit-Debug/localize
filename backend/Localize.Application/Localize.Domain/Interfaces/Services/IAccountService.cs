using Localize.Domain.DTOs.Request;

namespace Localize.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<string> CreateAccount(AccountRequest request);
        Task<string> Login(LoginRequest request);
        Task DeleteAccount(string email);
        Task UpdateAccount(string email, UpdateAccountRequest request);
    }
}
