using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoSerwis.Migrations
{
    /// <inheritdoc />
    public partial class AddMotorcycleVin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MotorcycleVin",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotorcycleVin",
                table: "Services");
        }
    }
}
