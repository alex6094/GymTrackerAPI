namespace GymTrackerAPI.Entities;

public class Exercise
{
	public int Id { get; set; }
	public required string? Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public MuscleGroup PrimaryMuscleGroup { get; set; }

	public enum MuscleGroup
	{
		Chest,
		Lats,
		Traps,
		Quads,
		Hamstrings,
		Shoulders,
		Biceps,
		Triceps,
		Core,
		Forearms
	}
}