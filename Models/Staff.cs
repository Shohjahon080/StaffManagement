using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Models
{

    
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Department")]
        public Department? Department { get; set; }


        public string PhotoFilePath { get; set; } 

    }
}
