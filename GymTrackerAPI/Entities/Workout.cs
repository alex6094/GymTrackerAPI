namespace GymTrackerAPI.Entities
{
	public class Workout
	{
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime FinishedAt { get; set; }
		public List<Exercise> Exercises { get; set; } = [];
	}
}