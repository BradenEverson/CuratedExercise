using ExerciseCuration.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseCuration.Data
{
    public class InMemoryExerciseDb : IExerciseData
    {
        private List<Exercise> exercises { get; set; }
        public InMemoryExerciseDb()
        {
            exercises = new List<Exercise>();
        }
        public Exercise add(Exercise exercise)
        {
            exercises.Add(exercise);
            return exercise;
        }

        public Exercise delete(int id)
        {
            Exercise exercise = exercises.FirstOrDefault(r => r.id == id);
            if(exercise != null)
            {
                exercises.Remove(exercise);
            }
            return exercise;
        }

        public Exercise getById(int id)
        {
            Exercise exercise = exercises.FirstOrDefault(r => r.id == id);
            if (exercise != null)
            {
                return exercise;
            }
            return null;
        }

        public Exercise update(Exercise updatedExercise)
        {
            Exercise exercise = exercises.FirstOrDefault(r => r.id == updatedExercise.id);
            if(exercise != null)
            {
                exercise.instructions = updatedExercise.instructions;
                exercise.workoutType = updatedExercise.workoutType;
                exercise.userRating = updatedExercise.userRating;
            }
            return exercise;
        }
        public int commit()
        {
            return 0;
        }
    }
}
