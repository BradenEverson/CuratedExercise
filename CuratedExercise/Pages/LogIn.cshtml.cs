using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseCuration.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserClass.Core;

namespace CuratedExercise
{
    public class LogInModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string email { get; set; }
        [BindProperty(SupportsGet = true)]
        public string password { get; set; }
        private readonly IUserData users;
        public LogInModel(IUserData users)
        {
            this.users = users;
        }
        public IActionResult OnPost()
        {
            User user = users.getByEmail(email);
            if(user != null)
            {
                if(password == user.password)
                {
                    return RedirectToPage("index", user);
                }
            }
            return RedirectToPage("Create", email, password);
        }
    }
}