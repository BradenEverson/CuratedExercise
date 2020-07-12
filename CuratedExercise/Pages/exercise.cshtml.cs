using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseCuration.Core;
using ExerciseCuration.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuratedExercise
{
    public class exerciseModel : PageModel
    {
        private IExerciseData exercises;
        public Exercise currentExercise;
        public IUserData users;
        public exerciseModel(IExerciseData exercises, IUserData users)
        {
            this.exercises = exercises;
            this.users = users;
        }
        public void OnGet()
        {
            currentExercise = exercises.generateNewWorkout(difficulty.all);
            exercises.add(currentExercise);
        }
        public IActionResult OnPost()
        {
            return Redirect("index");
        }
    }
}