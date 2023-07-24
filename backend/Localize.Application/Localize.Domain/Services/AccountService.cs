using Localize.Domain.DTOs.Request;
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

        public AccountService(IAccountRepository accountRepository,
                              ITokenService tokenService,
                              ILogger<AccountService> logger)
        {
            _accountRepository = accountRepository;
            _tokenService = tokenService;
            _logger = logger;
        }

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

        public async Task DeleteAccount(string email)
        {
            var account = await _accountRepository.GetAccountByEmail(email);

            if (account == null)
            {
                return;
            }

            await _accountRepository.DeleteAccount(account);
        }

        public async Task<string> Login(LoginRequest request)
        {
            var account = await _accountRepository.GetAccountByEmail(request.Email);

            if (account == null)
            {
                return null;
            }

            var passwordValid = BCrypt.Net.BCrypt.Verify(request.Password, account.Password);

            if (!passwordValid)
            {
                return null;
            }

            var token = _tokenService.GenerateToken(account.Name, account.Email);
            return token;
        }

        public async Task UpdateAccount(string email, UpdateAccountRequest request)
        {
            var oldAccount = await _accountRepository.GetAccountByEmail(email);

            if (ValidateUpdateAccount(oldAccount, request))
            {
                return;
            }

            oldAccount.UpdateName(request.Name);
            oldAccount.UpdateEmail(request.Email);

            await _accountRepository.UpdateAccount(oldAccount);
        }

        private bool ValidateUpdateAccount(Account oldAccount, UpdateAccountRequest newAccount)
        {
            if (oldAccount.Email == newAccount.Email &&
                oldAccount.Name == newAccount.Name)
            {
                return true;
            }

            return false;
        }
    }
}
