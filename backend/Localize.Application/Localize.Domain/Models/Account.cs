using System.ComponentModel.DataAnnotations;

namespace Localize.Domain.Models
{
    public class Account
    {
        public Account(string name,
                       string email,
                       string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
        }

        [Key]
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
