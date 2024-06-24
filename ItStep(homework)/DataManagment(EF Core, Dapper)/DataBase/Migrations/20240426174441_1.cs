using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Trainings_TrainingId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Trainings_TrainingId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_TrainingId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_TrainingId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Instructors");

            migrationBuilder.CreateTable(
                name: "EmployeeTraining",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    TrainingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTraining", x => new { x.EmployeesId, x.TrainingsId });
                    table.ForeignKey(
                        name: "FK_EmployeeTraining_Trainings_TrainingsId",
                        column: x => x.TrainingsId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTraining_TrainingsId",
                table: "EmployeeTraining",
                column: "TrainingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTraining");

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Managers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_TrainingId",
                table: "Managers",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_TrainingId",
                table: "Instructors",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Trainings_TrainingId",
                table: "Instructors",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Trainings_TrainingId",
                table: "Managers",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");
        }
    }
}
