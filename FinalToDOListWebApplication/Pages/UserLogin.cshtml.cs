using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalToDOListWebApplication.Model;

namespace FinalToDOListWebApplication.Pages
{
    public class UserLoginModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public LoginPage LoginPage { get; set; }
    }

}

