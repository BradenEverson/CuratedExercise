using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UserClass.Core;

namespace CuratedExercise.Pages
{
    public class IndexModel : PageModel
    {
        public User user;
        public IndexModel(User user = null)
        {
            this.user = user;
        }
        public IActionResult OnPost()
        {
            return Redirect("/exercise");
        }
    }
}
