using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseCuration.Core
{
    public class Exercise
    {
        public string instructions { get; }
        public workoutTypes workoutType { get; }
        public int userRating { get; set; }
    }
    public enum workoutTypes
    {
        ActiveRecovery,
        Aerobic,
        Anaerobic,
        Circuit,
        HIIT,
        Isometric,
        StrengthTraining
    }
}
