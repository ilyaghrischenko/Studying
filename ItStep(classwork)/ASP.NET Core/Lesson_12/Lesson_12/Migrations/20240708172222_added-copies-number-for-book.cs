using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC_2.Migrations
{
    /// <inheritdoc />
    public partial class addedcopiesnumberforbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopiesNumber",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiesNumber",
                table: "Book");
        }
    }
}
