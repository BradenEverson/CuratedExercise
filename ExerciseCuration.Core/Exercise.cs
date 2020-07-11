using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseCuration.Core
{
    public class Exercise
    {
        public int id { get; set; }
        public string instructions { get; set; }
        public workoutTypes workoutType { get; set; }
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
