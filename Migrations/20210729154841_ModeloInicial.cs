using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace carCenter.Migrations
{
    public partial class ModeloInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    primer_nombre = table.Column<string>(type: "Varchar (255)", nullable: true),
                    segundo_nombre = table.Column<string>(type: "Varchar (255)", nullable: true),
                    primer_apellido = table.Column<string>(type: "Varchar (255)", nullable: true),
                    segundo_apellido = table.Column<string>(type: "Varchar (255)", nullable: true),
                    tipo_documento = table.Column<string>(type: "Varchar (255)", nullable: true),
                    documento = table.Column<string>(type: "Varchar (20)", nullable: true),
                    celular = table.Column<string>(type: "Varchar (20)", nullable: true),
                    direccion = table.Column<string>(type: "Varchar (255)", nullable: true),
                    correo_electronico = table.Column<string>(type: "Varchar (255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
