using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FinalToDOListWebApplication.Model
{
    public class LoginPage
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Entry")]
        [Required(ErrorMessage = "Please Enter Email Address")]
        [MaxLength(30)]
        public String Username { get; set; }

        [Required]
       public String Password { get; set; }
    }
}
