
using System.ComponentModel.DataAnnotations;
namespace MVC1_portfolio.Models
{
    public class ContactViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }


    }
}
