using FluentValidation;
using GymTrackerAPI.Entities.DTOs;

namespace GymTrackerAPI.Entities.Validation
{
	public class ExerciseDtoValidator : AbstractValidator<ExerciseDto>
	{
		public ExerciseDtoValidator()
		{
			RuleFor(x => x.Name).ApplyRules(100);
			RuleFor(x => x.Description).ApplyRules(500);
		}
	}
}
