using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepInternetowy.Migrations
{
    /// <inheritdoc />
    public partial class descriptionsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Wielowątkowa, diaboliczna opowieść o tym jak szlachetne idee indywidualnej wolności w umysłach ludzi na wolność niegotowych, kształtowanych w uściskach carskiego samodzierżawia, przeradzają się w idee nihilizmu, bezwładne rewolucyjne ruchy i terroryzm.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Późne, dojrzałe dzieło wielkiego pisarza stanowi kwintesencję jego poglądów na życie i sztukę. Dowodem na uniwersalność i doniosłość przesłania powieści jest uhonorowanie jej międzynarodową nagrodą Prix Formentor, najwyższym europejskim wyróżnieniem po Literackiej Nagrodzie Nobla");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Cudze słowa uwodzą wizją śródziemnomorskiej wyspy szczęśliwej i krakowskich mglistych Plant, pachną świeżo pieczonym chlebem i pilawem z jagnięciną. Powoli odkrywają przed czytelnikiem tajemnicę notesów, pełnych cudzych słów.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");
        }
    }
}
