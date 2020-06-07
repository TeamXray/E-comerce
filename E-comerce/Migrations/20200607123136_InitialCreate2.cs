using Microsoft.EntityFrameworkCore.Migrations;

namespace E_comerce.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produit_commandecs_CommandecsCommandeId",
                table: "Produit");

            migrationBuilder.DropIndex(
                name: "IX_Produit_CommandecsCommandeId",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "CommandecsCommandeId",
                table: "Produit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommandecsCommandeId",
                table: "Produit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produit_CommandecsCommandeId",
                table: "Produit",
                column: "CommandecsCommandeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_commandecs_CommandecsCommandeId",
                table: "Produit",
                column: "CommandecsCommandeId",
                principalTable: "commandecs",
                principalColumn: "CommandeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
