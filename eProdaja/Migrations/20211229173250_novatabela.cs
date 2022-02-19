using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class novatabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PretragaIspit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrsteProizvodumId = table.Column<int>(type: "int", nullable: false),
                    KorisniciId = table.Column<int>(type: "int", nullable: false),
                    MinIznosPrometa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatumOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IznosPrometa = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PretragaIspit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PretragaIspit_Korisnici_KorisniciId",
                        column: x => x.KorisniciId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PretragaIspit_VrsteProizvoda_VrsteProizvodumId",
                        column: x => x.VrsteProizvodumId,
                        principalTable: "VrsteProizvoda",
                        principalColumn: "VrstaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PretragaIspit_KorisniciId",
                table: "PretragaIspit",
                column: "KorisniciId");

            migrationBuilder.CreateIndex(
                name: "IX_PretragaIspit_VrsteProizvodumId",
                table: "PretragaIspit",
                column: "VrsteProizvodumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PretragaIspit");
        }
    }
}
