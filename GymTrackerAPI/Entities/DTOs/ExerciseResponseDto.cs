using GymTrackerAPI.Entities.Enum;

namespace GymTrackerAPI.Entities.DTOs
{
	public class ExerciseResponseDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public MuscleGroup PrimaryMuscleGroup { get; set; }
	}
}
