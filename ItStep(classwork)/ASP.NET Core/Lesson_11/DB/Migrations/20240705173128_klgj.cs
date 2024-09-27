using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class klgj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyTasks_MyDates_MyDateId",
                table: "MyTasks");

            migrationBuilder.DropIndex(
                name: "IX_MyTasks_MyDateId",
                table: "MyTasks");

            migrationBuilder.DropColumn(
                name: "MyDateId",
                table: "MyTasks");

            migrationBuilder.AddColumn<int>(
                name: "DateId",
                table: "MyTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_DateId",
                table: "MyTasks",
                column: "DateId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyTasks_MyDates_DateId",
                table: "MyTasks",
                column: "DateId",
                principalTable: "MyDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyTasks_MyDates_DateId",
                table: "MyTasks");

            migrationBuilder.DropIndex(
                name: "IX_MyTasks_DateId",
                table: "MyTasks");

            migrationBuilder.DropColumn(
                name: "DateId",
                table: "MyTasks");

            migrationBuilder.AddColumn<int>(
                name: "MyDateId",
                table: "MyTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_MyDateId",
                table: "MyTasks",
                column: "MyDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyTasks_MyDates_MyDateId",
                table: "MyTasks",
                column: "MyDateId",
                principalTable: "MyDates",
                principalColumn: "Id");
        }
    }
}
