using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.API.Migrations
{
    /// <inheritdoc />
    public partial class initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "NutritionId",
                table: "Pets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_NutritionId",
                table: "Pets",
                column: "NutritionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Nutritions_NutritionId",
                table: "Pets",
                column: "NutritionId",
                principalTable: "Nutritions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Nutritions_NutritionId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_NutritionId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "NutritionId",
                table: "Pets");
        }
    }
}
