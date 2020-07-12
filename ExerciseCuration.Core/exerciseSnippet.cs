namespace ExerciseCuration.Core
{
    public class exerciseSnippet
    {
        public exerciseSnippet(string exerciseName, string instructions, int repsPerSet, int numberOfSets, goal goal, workoutTypes workoutType, difficulty difficulty)
        {
            this.exerciseName = exerciseName;
            this.instructions = instructions;
            RepsPerSet = repsPerSet;
            this.numberOfSets = numberOfSets;
            this.goal = goal;
            this.workoutType = workoutType;
            this.difficulty = difficulty;
        }

        public string exerciseName { get; set; }
        public string instructions { get; set; }
        public int RepsPerSet { get; set; }
        public int numberOfSets { get; set; }
        public goal goal { get; set; }
        public workoutTypes workoutType { get; }
        public difficulty difficulty { get; set; }
    }
}