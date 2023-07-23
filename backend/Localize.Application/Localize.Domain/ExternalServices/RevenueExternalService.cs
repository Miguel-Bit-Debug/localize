using Localize.Domain.DTOs.Response;
using Localize.Domain.Interfaces.ExternalServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Localize.Domain.ExternalServices
{
    public class RevenueExternalService : IRevenueExternalService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<RevenueExternalService> _logger;
        private readonly string BaseUrl;

        public RevenueExternalService(HttpClient httpClient,
                                      ILogger<RevenueExternalService> logger,
                                      IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            BaseUrl = configuration["RevenueBaseUrl"]!;
        }

        public async Task<RevenueResponse> GetRevenueDtaByCnpj(string cnpj)
        {
            try
            {
                _logger.LogInformation($"Buscando dados do CNPJ - {cnpj}");

                var response = await _httpClient.GetAsync($"{BaseUrl}/cnpj/{cnpj}");
                var result = await response.Content.ReadAsStringAsync();
                var revenue = JsonConvert.DeserializeObject<RevenueResponse>(result);

                return revenue;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao realizar busca pelo cnpj {cnpj} {ex.Message}");
                throw;
            }
        }
    }
}
