using FluentValidation;

namespace GymTrackerAPI.Entities.Validation
{
	public static class ValidationRules
	{
		public static IRuleBuilderOptions<T, string> ApplyRules<T>(this IRuleBuilder<T, string> ruleBuilder, int maximumLength)
		{
			return ruleBuilder
				.NotEmpty()
				.MaximumLength(maximumLength)
				.Matches(@"^[a-zA-Z0-9\s\(\)\.,\-]*$")
				.WithMessage("{PropertyName} contains invalid characters or is too long.");
		}
	}
}
