using ExerciseCuration.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseCuration.Data
{
    public interface IExerciseData
    {
        public Exercise add(Exercise exercise);
        public Exercise delete(int id);
        public Exercise generateNewWorkout(difficulty difficulty);
        public void updateDict(exerciseSnippet target, double increment);
        public Exercise getById(int id);
        public int commit();
        public int getMax();
    }
}
