using GymTrackerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymTrackerAPI.Data
{
	public class DataContext : DbContext	
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) // This constructor is used to pass the options to the base DbContext class
		{
		}

		public DbSet<User> Users { get; set; } // DbSet for User entities
		public DbSet<Workout> Workouts { get; set; } // DbSet for Workout entities
		public DbSet<Exercise> Exercises { get; set; } // DbSet for Exercise entities
	}
}