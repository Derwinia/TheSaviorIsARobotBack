using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSaviorIsARobotAPI.Migrations
{
    /// <inheritdoc />
    public partial class co2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CO2",
                table: "Worlds",
                newName: "Co2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Co2",
                table: "Worlds",
                newName: "CO2");
        }
    }
}
