namespace ExerciseCuration.Core
{
    public class exerciseSnippet
    {
        public string instructions { get; set; }
        public workoutTypes workoutType { get; }
        public bodyGroup bodyGroup { get; }
        public int userRating { get; set; }
    }
}