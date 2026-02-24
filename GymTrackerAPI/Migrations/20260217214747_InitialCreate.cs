using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrackerAPI.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "Users",
					columns: table => new
					{
						Id = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
						Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
						PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
						CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Users", x => x.Id);
					});

			migrationBuilder.CreateTable(
					name: "Workouts",
					columns: table => new
					{
						Id = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
						FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
						UserId = table.Column<int>(type: "int", nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Workouts", x => x.Id);
						table.ForeignKey(
											name: "FK_Workouts_Users_UserId",
											column: x => x.UserId,
											principalTable: "Users",
											principalColumn: "Id");
					});

			migrationBuilder.CreateTable(
					name: "Exercises",
					columns: table => new
					{
						Id = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
						Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
						PrimaryMuscleGroup = table.Column<int>(type: "int", nullable: false),
						WorkoutId = table.Column<int>(type: "int", nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Exercises", x => x.Id);
						table.ForeignKey(
											name: "FK_Exercises_Workouts_WorkoutId",
											column: x => x.WorkoutId,
											principalTable: "Workouts",
											principalColumn: "Id");
					});

			migrationBuilder.CreateIndex(
					name: "IX_Exercises_WorkoutId",
					table: "Exercises",
					column: "WorkoutId");

			migrationBuilder.CreateIndex(
					name: "IX_Workouts_UserId",
					table: "Workouts",
					column: "UserId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "Exercises");

			migrationBuilder.DropTable(
					name: "Workouts");

			migrationBuilder.DropTable(
					name: "Users");
		}
	}
}
