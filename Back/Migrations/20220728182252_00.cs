using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Api.Migrations
{
    public partial class _00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataAlteracao", "DataCadastro", "Descricao" },
                values: new object[] { 1, null, new DateTime(2022, 7, 28, 15, 22, 52, 364, DateTimeKind.Local).AddTicks(2865), "Produto 01" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataAlteracao", "DataCadastro", "Descricao" },
                values: new object[] { 2, null, new DateTime(2022, 7, 28, 15, 22, 52, 364, DateTimeKind.Local).AddTicks(2874), "Produto 02" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
