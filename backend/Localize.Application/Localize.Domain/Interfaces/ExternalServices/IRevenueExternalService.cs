using Localize.Domain.DTOs.Response;

namespace Localize.Domain.Interfaces.ExternalServices
{
    public interface IRevenueExternalService
    {
        Task<RevenueResponse> GetRevenueDtaByCnpj(string cnpj);
    }
}
