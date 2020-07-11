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
        public Exercise update(Exercise updatedExercise);
        public Exercise getById(int id);
    }
}
