using Localize.Domain.DTOs;

namespace Localize.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<string> CreateAccount(AccountRequest request);
        Task<string> Login(LoginRequest request);
    }
}
