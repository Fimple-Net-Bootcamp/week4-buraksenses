using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.API.Migrations
{
    /// <inheritdoc />
    public partial class SocialInteractionsDbSetcreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetSocialInteraction_SocialInteraction_SocialInteractionsId",
                table: "PetSocialInteraction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialInteraction",
                table: "SocialInteraction");

            migrationBuilder.RenameTable(
                name: "SocialInteraction",
                newName: "SocialInteractions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialInteractions",
                table: "SocialInteractions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetSocialInteraction_SocialInteractions_SocialInteractionsId",
                table: "PetSocialInteraction",
                column: "SocialInteractionsId",
                principalTable: "SocialInteractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetSocialInteraction_SocialInteractions_SocialInteractionsId",
                table: "PetSocialInteraction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialInteractions",
                table: "SocialInteractions");

            migrationBuilder.RenameTable(
                name: "SocialInteractions",
                newName: "SocialInteraction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialInteraction",
                table: "SocialInteraction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetSocialInteraction_SocialInteraction_SocialInteractionsId",
                table: "PetSocialInteraction",
                column: "SocialInteractionsId",
                principalTable: "SocialInteraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
