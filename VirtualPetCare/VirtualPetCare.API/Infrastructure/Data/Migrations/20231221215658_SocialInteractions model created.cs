using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.API.Migrations
{
    /// <inheritdoc />
    public partial class SocialInteractionsmodelcreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialInteraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialInteraction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetSocialInteraction",
                columns: table => new
                {
                    PetsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SocialInteractionsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetSocialInteraction", x => new { x.PetsId, x.SocialInteractionsId });
                    table.ForeignKey(
                        name: "FK_PetSocialInteraction_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetSocialInteraction_SocialInteraction_SocialInteractionsId",
                        column: x => x.SocialInteractionsId,
                        principalTable: "SocialInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetSocialInteraction_SocialInteractionsId",
                table: "PetSocialInteraction",
                column: "SocialInteractionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetSocialInteraction");

            migrationBuilder.DropTable(
                name: "SocialInteraction");
        }
    }
}
