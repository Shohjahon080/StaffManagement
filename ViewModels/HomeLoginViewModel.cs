using Microsoft.AspNetCore.Http;
using StaffManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StaffManagement.ViewModels
{
    public class HomeLoginViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required] 
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
       
    }
}
