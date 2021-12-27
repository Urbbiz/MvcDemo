using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class RegistrationModel
    {
        [DisplayName("Just first name")]
        [Required]
        [MinLength(3)]

        public string? Name { get; set; }

        public string? Address { get; set; }

        [EmailAddress(ErrorMessage = "Iveskitte teisinga email")]
        [Required]
        public string? Email { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
