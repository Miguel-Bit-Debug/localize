namespace Localize.Domain.DTOs.Request
{
    public class AccountRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public void HashPassword(string password)
        {
            Password = password;
        }
    }
}
