using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chaufferie.ChargeMS.Data.Migrations
{
    public partial class DbTogp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reunion_aprés_cloture",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reunion_aprés_cloture", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reunion_avant_cloture",
                columns: table => new
                {
                    Reunion_avant_clotureId = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reunion_avant_cloture", x => x.Reunion_avant_clotureId);
                });

            migrationBuilder.CreateTable(
                name: "TypeReunion",
                columns: table => new
                {
                    TypeReunionId = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeReunion", x => x.TypeReunionId);
                });

            migrationBuilder.CreateTable(
                name: "TypeReunion_sous_service",
                columns: table => new
                {
                    TypeReunion_sous_serviceId = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeReunion_sous_service", x => x.TypeReunion_sous_serviceId);
                });

            migrationBuilder.CreateTable(
                name: "Réunions",
                columns: table => new
                {
                    RéunionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Objet = table.Column<string>(nullable: true),
                    DateDebutReunion = table.Column<string>(nullable: true),
                    DateCreation = table.Column<string>(nullable: true),
                    HeureDebut = table.Column<string>(nullable: true),
                    HeureFin = table.Column<string>(nullable: true),
                    TypeReunionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Réunions", x => x.RéunionId);
                    table.ForeignKey(
                        name: "FK_Réunions_TypeReunion_TypeReunionId",
                        column: x => x.TypeReunionId,
                        principalTable: "TypeReunion",
                        principalColumn: "TypeReunionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Réunions_TypeReunionId",
                table: "Réunions",
                column: "TypeReunionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reunion_aprés_cloture");

            migrationBuilder.DropTable(
                name: "Reunion_avant_cloture");

            migrationBuilder.DropTable(
                name: "Réunions");

            migrationBuilder.DropTable(
                name: "TypeReunion_sous_service");

            migrationBuilder.DropTable(
                name: "TypeReunion");
        }
    }
}
