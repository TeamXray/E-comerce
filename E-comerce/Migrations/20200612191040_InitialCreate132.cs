using Microsoft.EntityFrameworkCore.Migrations;

namespace E_comerce.Migrations
{
    public partial class InitialCreate132 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodePostal",
                table: "commandecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "commandecs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "couvernement",
                table: "commandecs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodePostal",
                table: "commandecs");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "commandecs");

            migrationBuilder.DropColumn(
                name: "couvernement",
                table: "commandecs");
        }
    }
}
