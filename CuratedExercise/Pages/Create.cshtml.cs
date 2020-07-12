using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserClass.Core;

namespace CuratedExercise
{
    public class CreateModel : PageModel
    {
        public string email = "";
        public string password = "";
        public CreateModel(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public IActionResult OnPost()
        {
            User user = new User();

            return RedirectToPage("index", user);
        }
    }
}