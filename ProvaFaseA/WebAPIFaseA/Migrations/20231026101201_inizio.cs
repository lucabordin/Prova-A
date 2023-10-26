using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIFaseA.Migrations
{
    /// <inheritdoc />
    public partial class inizio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrelli",
                columns: table => new
                {
                    IdCarrello = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdProdotto = table.Column<int>(type: "int", nullable: false),
                    PrezzoProdotto = table.Column<double>(type: "float", nullable: false),
                    QuantitaProdotto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrelli", x => x.IdCarrello);
                });

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDiNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passward = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Prodotti",
                columns: table => new
                {
                    IdProdotto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false),
                    Giacenza = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotti", x => x.IdProdotto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrelli");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Prodotti");
        }
    }
}
