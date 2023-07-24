namespace Localize.Domain.DTOs.Response
{
    public class AccountResponse
    {
        public AccountResponse(string name,
                               string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
