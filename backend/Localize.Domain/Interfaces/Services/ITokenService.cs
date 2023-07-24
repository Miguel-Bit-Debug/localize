namespace Localize.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        string GenerateToken(string name, string email);
    }
}
