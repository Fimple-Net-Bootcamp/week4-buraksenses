using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.API.Migrations
{
    /// <inheritdoc />
    public partial class HealthStatustablechangedv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "HealthStatusList",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetName",
                table: "HealthStatusList");
        }
    }
}
