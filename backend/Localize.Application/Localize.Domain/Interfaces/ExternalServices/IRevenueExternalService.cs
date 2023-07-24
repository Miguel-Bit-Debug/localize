namespace Localize.Domain.Interfaces.ExternalServices
{
    public interface IRevenueExternalService
    {
        Task<string> GetRevenueDtaByCnpj(string cnpj);
    }
}
