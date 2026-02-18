namespace GymTrackerAPI.Entities
{
	public class User
	{
		public int Id { get; set; }
		public required string Username { get; set; } 
		public required string Email { get; set; }
		public required string PasswordHash { get; set; }
		public DateTime CreatedAt { get; set; }
		public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
	}
}
