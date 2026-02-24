using GymTrackerAPI.Data;
using GymTrackerAPI.Entities;
using GymTrackerAPI.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GymTrackerAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExerciseController : ControllerBase
	{
		private readonly DataContext _context;
		public ExerciseController(DataContext context)
		{
			_context = context;
		}

		[HttpPost]
		public async Task<ActionResult<ExerciseResponseDto>> CreateExercise(ExerciseDto dto)
		{
			var exercise = _mapper.Map<Exercise>(dto);

			_context.Exercises.Add(exercise);
			await _context.SaveChangesAsync();

			var response = new ExerciseResponseDto
			{
				Id = exercise.Id,
				Name = exercise.Name,
				Description = exercise.Description,
				PrimaryMuscleGroup = exercise.PrimaryMuscleGroup
			};

			return CreatedAtAction(nameof(GetExercise), new { id = exercise.Id }, response);
		}


		[HttpGet]
		public async Task<IActionResult> GetExercises()
		{
			var exercises = await _context.Exercises.ToListAsync();
			if (exercises == null || exercises.Count == 0)
				return NotFound("No exercises found");
			return Ok(exercises);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetExercise(int id)
		{
			var exercise = await _context.Exercises.FindAsync(id);
			if (exercise == null)
				return NotFound("The exercise was not found");
			return Ok(exercise);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateExercise(int id, ExerciseDto dto)
		{
			var exercise = await _context.Exercises.FindAsync(id);
			if (exercise == null)
				return NotFound("The exercise was not found.");

			exercise.Name = dto.Name;
			exercise.Description = dto.Description;
			exercise.PrimaryMuscleGroup = dto.PrimaryMuscleGroup;

			await _context.SaveChangesAsync();

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteExercise(int id)
		{
			var exercise = await _context.Exercises.FindAsync(id);
			if (exercise == null)
				return NotFound("The exercise was not found");
			_context.Exercises.Remove(exercise);
			await _context.SaveChangesAsync();
			return NoContent();
		}
	}
}