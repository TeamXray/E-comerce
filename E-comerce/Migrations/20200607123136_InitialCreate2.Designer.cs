﻿// <auto-generated />
using System;
using E_comerce.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_comerce.Migrations
{
    [DbContext(typeof(Datacontextcs))]
    [Migration("20200607123136_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("E_comerce.Entity.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nom_cat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CategorieId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("E_comerce.Entity.Commandecs", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MoyenPayment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PrixTotal")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateCommande")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("etat_payment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CommandeId");

                    b.HasIndex("UserId");

                    b.ToTable("commandecs");
                });

            modelBuilder.Entity("E_comerce.Entity.Produit", b =>
                {
                    b.Property<int>("id_prod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Sous_catId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnName("Image")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnName("Nom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("prix")
                        .HasColumnName("Prix")
                        .HasColumnType("float");

                    b.Property<int>("quantite")
                        .HasColumnName("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("solde")
                        .HasColumnName("Solde")
                        .HasColumnType("int");

                    b.HasKey("id_prod");

                    b.HasIndex("Sous_catId");

                    b.HasIndex("UserId");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("E_comerce.Entity.Sous_cat", b =>
                {
                    b.Property<int>("Sous_catId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<string>("nom_cat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Sous_catId");

                    b.HasIndex("CategorieID");

                    b.ToTable("Sous_Cats");
                });

            modelBuilder.Entity("E_comerce.Entity.Users", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomScoite")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<string>("Roles")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Token")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("adresse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("etat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("logoCo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("telephone")
                        .HasColumnType("int");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_comerce.Entity.VenteFlash", b =>
                {
                    b.Property<int>("VenteFlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("prixV")
                        .HasColumnType("float");

                    b.Property<int>("quantite")
                        .HasColumnType("int");

                    b.HasKey("VenteFlId");

                    b.HasIndex("UserId");

                    b.ToTable("venteFlashes");
                });

            modelBuilder.Entity("E_comerce.Entity.Commandecs", b =>
                {
                    b.HasOne("E_comerce.Entity.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_comerce.Entity.Produit", b =>
                {
                    b.HasOne("E_comerce.Entity.Sous_cat", "Sous_Cat")
                        .WithMany("produits")
                        .HasForeignKey("Sous_catId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_comerce.Entity.Users", "User")
                        .WithMany("produits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_comerce.Entity.Sous_cat", b =>
                {
                    b.HasOne("E_comerce.Entity.Categorie", "Categorie")
                        .WithMany("sous_Cats")
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_comerce.Entity.VenteFlash", b =>
                {
                    b.HasOne("E_comerce.Entity.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
