using Localize.Domain.Interfaces.ExternalServices;
using Localize.Domain.Interfaces.Services;
using Localize.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Localize.Domain.ExternalServices
{
    public class RevenueExternalService : IRevenueExternalService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<RevenueExternalService> _logger;
        private readonly string BaseUrl;
        private readonly IRevenueService _revenueService;

        public RevenueExternalService(HttpClient httpClient,
                                      ILogger<RevenueExternalService> logger,
                                      IConfiguration configuration,
                                      IRevenueService revenueService)
        {
            _httpClient = httpClient;
            _logger = logger;
            BaseUrl = configuration["RevenueBaseUrl"]!;
            _revenueService = revenueService;
        }

        public async Task<string> GetRevenueDtaByCnpj(string cnpj)
        {
            try
            {
                _logger.LogInformation($"Buscando dados do CNPJ - {cnpj}");

                var response = await _httpClient.GetAsync($"{BaseUrl}/cnpj/{cnpj}");

                if (response == null)
                {
                    _logger.LogInformation($"Dados nulo para cnpj: {cnpj}");
                    return null;
                }

                var result = await response.Content.ReadAsStringAsync();

                var revenue = new Revenue(cnpj, result);

                var revenueExists = await _revenueService.GetRevenueDataByCnpj(cnpj);

                if (revenueExists != null)
                {
                    return revenueExists.Resultado;
                }

                await _revenueService.SaveRevenueData(revenue);

                _logger.LogInformation($"Dados obtidos com sucesso!");

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao realizar busca pelo cnpj {cnpj} {ex.Message}");
                throw;
            }
        }
    }
}
