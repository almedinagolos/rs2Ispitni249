using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class baza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PretragaIspit_Korisnici_KorisniciId",
                table: "PretragaIspit");

            migrationBuilder.RenameColumn(
                name: "KorisniciId",
                table: "PretragaIspit",
                newName: "KupciId");

            migrationBuilder.RenameIndex(
                name: "IX_PretragaIspit_KorisniciId",
                table: "PretragaIspit",
                newName: "IX_PretragaIspit_KupciId");

            migrationBuilder.InsertData(
                table: "Narudzbe",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "Datum", "KupacID", "Otkazano", "Status" },
                values: new object[,]
                {
                    { 1, "AAA", new DateTime(2022, 2, 16, 16, 50, 4, 549, DateTimeKind.Local).AddTicks(8194), 1, false, true },
                    { 2, "BBB", new DateTime(2022, 2, 16, 16, 50, 4, 550, DateTimeKind.Local).AddTicks(2913), 2, false, true },
                    { 3, "CCC", new DateTime(2022, 2, 16, 16, 50, 4, 550, DateTimeKind.Local).AddTicks(3125), 2, false, true }
                });

            migrationBuilder.InsertData(
                table: "PretragaIspit",
                columns: new[] { "Id", "DatumDo", "DatumOd", "IznosPrometa", "KupciId", "MinIznosPrometa", "VrsteProizvodumId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 16, 16, 50, 4, 551, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 2, 6, 16, 50, 4, 550, DateTimeKind.Local).AddTicks(9851), 1000m, 1, 900m, 1 },
                    { 2, new DateTime(2022, 2, 16, 16, 50, 4, 551, DateTimeKind.Local).AddTicks(3034), new DateTime(2022, 2, 6, 16, 50, 4, 551, DateTimeKind.Local).AddTicks(2961), 1000m, 2, 900m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Izlazi",
                columns: new[] { "IzlazID", "BrojRacuna", "Datum", "IznosBezPDV", "IznosSaPDV", "KorisnikID", "NarudzbaID", "SkladisteID", "Zakljucen" },
                values: new object[,]
                {
                    { 1, "A", new DateTime(2022, 2, 16, 16, 50, 4, 542, DateTimeKind.Local).AddTicks(7491), 0m, 1000m, 2, 1, 1, false },
                    { 2, "BBB", new DateTime(2022, 2, 16, 16, 50, 4, 550, DateTimeKind.Local).AddTicks(6880), 1950m, 2000m, 1, 2, 1, false },
                    { 3, "CCC", new DateTime(2022, 2, 16, 16, 50, 4, 550, DateTimeKind.Local).AddTicks(7110), 2950m, 3000m, 1, 3, 1, false }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaID", "Kolicina", "NarudzbaID", "ProizvodID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 },
                    { 3, 2, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "IzlazStavke",
                columns: new[] { "IzlazStavkaID", "Cijena", "IzlazID", "Kolicina", "Popust", "ProizvodID" },
                values: new object[] { 1, 1000m, 1, 1, 2m, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_PretragaIspit_Kupci_KupciId",
                table: "PretragaIspit",
                column: "KupciId",
                principalTable: "Kupci",
                principalColumn: "KupacID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PretragaIspit_Kupci_KupciId",
                table: "PretragaIspit");

            migrationBuilder.DeleteData(
                table: "IzlazStavke",
                keyColumn: "IzlazStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PretragaIspit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PretragaIspit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "KupciId",
                table: "PretragaIspit",
                newName: "KorisniciId");

            migrationBuilder.RenameIndex(
                name: "IX_PretragaIspit_KupciId",
                table: "PretragaIspit",
                newName: "IX_PretragaIspit_KorisniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_PretragaIspit_Korisnici_KorisniciId",
                table: "PretragaIspit",
                column: "KorisniciId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
