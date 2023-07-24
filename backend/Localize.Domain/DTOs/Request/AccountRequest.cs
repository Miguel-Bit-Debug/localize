using System.ComponentModel.DataAnnotations;

namespace Localize.Domain.DTOs.Request
{
    public class AccountRequest
    {
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email deve ser preenchido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha deve ser preenchida")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirmação de senha deve ser preenchida")]
        public string ConfirmPassword { get; set; }

        public void HashPassword(string password)
        {
            Password = password;
        }
    }
}
