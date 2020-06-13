using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_comerce.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom_cat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategorieId);
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
                    Token = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true),
                    telephone = table.Column<int>(nullable: false),
                    etat = table.Column<string>(nullable: true),
                    logoCo = table.Column<string>(nullable: true),
                    NomScoite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "Sous_Cats",
                columns: table => new
                {
                    Sous_catId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom_cat = table.Column<string>(nullable: true),
                    CategorieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sous_Cats", x => x.Sous_catId);
                    table.ForeignKey(
                        name: "FK_Sous_Cats_categories_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sommeTotal = table.Column<float>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "venteFlashes",
                columns: table => new
                {
                    VenteFlId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    prixV = table.Column<float>(nullable: false),
                    nom = table.Column<string>(nullable: false),
                    Desc = table.Column<string>(nullable: false),
                    quantite = table.Column<int>(nullable: false),
                    image = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venteFlashes", x => x.VenteFlId);
                    table.ForeignKey(
                        name: "FK_venteFlashes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
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
                    Sous_catId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.id_prod);
                    table.ForeignKey(
                        name: "FK_Produit_Sous_Cats_Sous_catId",
                        column: x => x.Sous_catId,
                        principalTable: "Sous_Cats",
                        principalColumn: "Sous_catId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produit_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "commandecs",
                columns: table => new
                {
                    CommandeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dateCommande = table.Column<DateTime>(nullable: false),
                    PrixTotal = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    etat_payment = table.Column<string>(nullable: true),
                    MoyenPayment = table.Column<string>(nullable: true),
                    CartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commandecs", x => x.CommandeId);
                    table.ForeignKey(
                        name: "FK_commandecs_carts_CartId",
                        column: x => x.CartId,
                        principalTable: "carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_commandecs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cartitems",
                columns: table => new
                {
                    cartItId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    qty = table.Column<int>(nullable: false),
                    prixp = table.Column<float>(nullable: false),
                    produitId = table.Column<int>(nullable: false),
                    cartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartitems", x => x.cartItId);
                    table.ForeignKey(
                        name: "FK_cartitems_carts_cartId",
                        column: x => x.cartId,
                        principalTable: "carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartitems_Produit_produitId",
                        column: x => x.produitId,
                        principalTable: "Produit",
                        principalColumn: "id_prod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartitems_cartId",
                table: "cartitems",
                column: "cartId");

            migrationBuilder.CreateIndex(
                name: "IX_cartitems_produitId",
                table: "cartitems",
                column: "produitId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserId",
                table: "carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_commandecs_CartId",
                table: "commandecs",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_commandecs_UserId",
                table: "commandecs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_Sous_catId",
                table: "Produit",
                column: "Sous_catId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_UserId",
                table: "Produit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sous_Cats_CategorieID",
                table: "Sous_Cats",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_venteFlashes_UserId",
                table: "venteFlashes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartitems");

            migrationBuilder.DropTable(
                name: "commandecs");

            migrationBuilder.DropTable(
                name: "venteFlashes");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "Sous_Cats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
