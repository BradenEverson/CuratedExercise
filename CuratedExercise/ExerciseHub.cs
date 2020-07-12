using ExerciseCuration.Core;
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
            double incrementer = increment == "-1" ? 0.02 : 0.01;
            exercises.updateDict(exercises.getById(exercises.getMax()).exercisesInWorkout[exercises.getById(exercises.getMax()).exercisesInWorkout.Count-1], incrementer);
            Exercise newExercise = exercises.generateNewWorkout(difficulty.all);
            exercises.add(newExercise);
            await Clients.Caller.SendAsync("sendExercise", newExercise.exercisesInWorkout[0].exerciseName, newExercise.exercisesInWorkout[0].instructions);
        }
    }
}
