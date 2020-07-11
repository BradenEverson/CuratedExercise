using ExerciseCuration.Data;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuratedExercise
{
    public class ExerciseHub : Hub
    {
        readonly IExerciseData exercises;
        public ExerciseHub(IExerciseData exercises)
        {
            this.exercises = exercises;
        }
        public async Task sendExerciseFeedback(string increment)
        {
            exercises.updateDict(exercises.getById(exercises.getMax()).exercisesInWorkout[exercises.getById(exercises.getMax()).exercisesInWorkout.Count-1], int.Parse(increment));
        }
    }
}
