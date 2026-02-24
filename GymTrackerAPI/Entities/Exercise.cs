using System.ComponentModel.DataAnnotations;
using GymTrackerAPI.Entities.Enum;

namespace GymTrackerAPI.Entities;

public class Exercise
{
	public int Id { get; set; }
	[Required]
	[MaxLength(100)]
	public required string Name { get; set; } = string.Empty;
	[MaxLength(500)]

	public string Description { get; set; } = string.Empty;
	public MuscleGroup PrimaryMuscleGroup { get; set; }
}