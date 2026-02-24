using GymTrackerAPI.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace GymTrackerAPI.Entities.DTOs
{
	public class ExerciseDto
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = string.Empty;
		public MuscleGroup PrimaryMuscleGroup { get; set; }
	}
}
