using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_comerce.Migrations
{
    public partial class ajoutDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "labelCats",
                columns: table => new
                {
                    LabelId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labelCats", x => x.LabelId);
                });

            migrationBuilder.CreateTable(
                name: "typeImms",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeImms", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "typeTechs",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeTechs", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "typeVets",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeVets", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LabelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategorieId);
                    table.ForeignKey(
                        name: "FK_categories_labelCats_LabelId",
                        column: x => x.LabelId,
                        principalTable: "labelCats",
                        principalColumn: "LabelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "autres",
                columns: table => new
                {
                    AutreId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeAutre = table.Column<string>(nullable: true),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autres", x => x.AutreId);
                    table.ForeignKey(
                        name: "FK_autres_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "immeubles",
                columns: table => new
                {
                    ImmId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeImmId = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_immeubles", x => x.ImmId);
                    table.ForeignKey(
                        name: "FK_immeubles_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_immeubles_typeImms_TypeImmId",
                        column: x => x.TypeImmId,
                        principalTable: "typeImms",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produits",
                columns: table => new
                {
                    id_prod = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Quantite = table.Column<int>(nullable: false),
                    Prix = table.Column<float>(nullable: false),
                    Solde = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produits", x => x.id_prod);
                    table.ForeignKey(
                        name: "FK_produits_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "technologies",
                columns: table => new
                {
                    TechId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marque = table.Column<string>(nullable: true),
                    TypeTechId = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_technologies", x => x.TechId);
                    table.ForeignKey(
                        name: "FK_technologies_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_technologies_typeTechs_TypeTechId",
                        column: x => x.TypeTechId,
                        principalTable: "typeTechs",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vetements",
                columns: table => new
                {
                    VetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mode = table.Column<string>(nullable: true),
                    Couleur = table.Column<string>(nullable: true),
                    Taille = table.Column<string>(nullable: true),
                    Marque = table.Column<string>(nullable: true),
                    TypeVetId = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vetements", x => x.VetId);
                    table.ForeignKey(
                        name: "FK_vetements_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vetements_typeVets_TypeVetId",
                        column: x => x.TypeVetId,
                        principalTable: "typeVets",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_autres_CategorieId",
                table: "autres",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_categories_LabelId",
                table: "categories",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_immeubles_CategorieId",
                table: "immeubles",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_immeubles_TypeImmId",
                table: "immeubles",
                column: "TypeImmId");

            migrationBuilder.CreateIndex(
                name: "IX_produits_CategorieId",
                table: "produits",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_technologies_CategorieId",
                table: "technologies",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_technologies_TypeTechId",
                table: "technologies",
                column: "TypeTechId");

            migrationBuilder.CreateIndex(
                name: "IX_vetements_CategorieId",
                table: "vetements",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_vetements_TypeVetId",
                table: "vetements",
                column: "TypeVetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autres");

            migrationBuilder.DropTable(
                name: "immeubles");

            migrationBuilder.DropTable(
                name: "produits");

            migrationBuilder.DropTable(
                name: "technologies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "vetements");

            migrationBuilder.DropTable(
                name: "typeImms");

            migrationBuilder.DropTable(
                name: "typeTechs");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "typeVets");

            migrationBuilder.DropTable(
                name: "labelCats");
        }
    }
}
