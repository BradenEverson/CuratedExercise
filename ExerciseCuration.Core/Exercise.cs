using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseCuration.Core
{
    public class Exercise
    {
        private readonly List<exerciseSnippet> exercises = new List<exerciseSnippet>()
        {

        };
        public int id { get; set; }
        public List<exerciseSnippet> exercisesInWorkout { get; }
        public Exercise(bodyGroup bodyGroup, workoutTypes workoutType, int[] timeRange, int[] amountRange, int exerciseAmount, difficulty difficulty, List<exerciseSnippet> liked, List<exerciseSnippet> disliked)
        {
            for(int i = 0; i < exerciseAmount; i++)
            {
                generateExercise(workoutType, difficulty, timeRange, amountRange, liked, disliked);
            }
        }
        private void generateExercise(workoutTypes workoutType, difficulty difficulty, int[] timeRange, int[] amountRange, List<exerciseSnippet> liked, List<exerciseSnippet> disliked)
        {
            List<exerciseSnippet> filteredDownExercises = exercises.Where(r => r.workoutType == workoutType).ToList();
            exerciseSnippet exerciseSnippet = filteredDownExercises[staticRandom.Instance.Next(0, filteredDownExercises.Count - 1)];
            exerciseSnippet.instructions = exerciseSnippet.instructions.Replace("<time>", staticRandom.Instance.Next(timeRange[0], timeRange[1]).ToString()).Replace("<num>", staticRandom.Instance.Next(amountRange[0], amountRange[1]).ToString());
            if (disliked.Contains(exerciseSnippet))
            {
                exercisesInWorkout.Add(liked[staticRandom.Instance.Next(0, liked.Count - 1)]);
            }
            else
            {
                exercisesInWorkout.Add(exerciseSnippet);
            }
        }
    }
    public enum workoutTypes
    {
        ActiveRecovery,
        Aerobic,
        Anaerobic,
        Circuit,
        Isometric,
        StrengthTraining
    }
    public enum bodyGroup
    {
        back,
        chest,
    }
    public enum difficulty
    {
        beginner,
        intermidiate,
        advanced,
        all
    }
    public enum goal
    {

    }
}
