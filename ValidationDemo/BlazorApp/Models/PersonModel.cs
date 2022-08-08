using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Invalid first name length")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Invalid last name length")]
        public string LastName { get; set; }

        [Range(0, 125, ErrorMessage = "Invalid age")]
        public int Age { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You need to give consent to continue")] // needs to be true in order to continue with this form
        public bool GaveConsent { get; set; }

    }
}
