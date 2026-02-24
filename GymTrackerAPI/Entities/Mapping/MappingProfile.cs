using AutoMapper;
using GymTrackerAPI.Entities.DTOs;

namespace GymTrackerAPI.Entities.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ExerciseDto, Exercise>(); // Map from ExerciseDto to Exercise
			CreateMap<Exercise, ExerciseResponseDto>(); // Map from Exercise to ExerciseResponseDto
		}
	}
}
