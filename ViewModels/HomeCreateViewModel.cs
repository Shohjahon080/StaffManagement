using Microsoft.AspNetCore.Http;
using StaffManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StaffManagement.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Department")]
        public Department? Department { get; set; }


        //[MaxFileSize(800)]
        //[AllowedExtensions(new string[] {".jpg", ".png"})]

        public IFormFile Photo { get; set; }

    }
}
