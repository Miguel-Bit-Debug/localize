using Localize.Domain.DTOs;
using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Interfaces.Services;
using Localize.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Localize.Domain.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITokenService _tokenService;
        private readonly ILogger<AccountService> _logger;

        public async Task<string> CreateAccount(AccountRequest request)
        {
            try
            {
                _logger.LogInformation($"Iniciando criação de conta - {request.Name}");

                if (request.Password != request.ConfirmPassword)
                {
                    return null;
                }

                var accountExists = await _accountRepository.CheckAccountExists(request.Email);

                if (accountExists)
                {
                    return "Account already exists";
                }

                request.HashPassword(BCrypt.Net.BCrypt.HashPassword(request.Password, 10));

                var account = new Account(request.Name,
                                          request.Email,
                                          request.Password);

                await _accountRepository.CreateAccount(account);
                _logger.LogInformation($"Conta criada com sucesso. {request.Name}");

                var token = _tokenService.GenerateToken(request.Name, request.Email);
                return token;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"erro ao criar a conta. {request.Name} - Erro {ex.Message}");
                throw ex;
            }
        }

        public Task<string> Login(LoginRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
