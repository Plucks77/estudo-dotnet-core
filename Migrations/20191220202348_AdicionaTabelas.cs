using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class AdicionaTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Senha = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);                    
                });

            migrationBuilder.CreateTable(
                name: "Artigo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(maxLength: 60, nullable: false),
                    Conteudo = table.Column<string>(nullable: false),
                    Pessoa_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artigo_Pessoa_Pessoa_ID",
                        column: x => x.Pessoa_ID,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_Pessoa_ID",
                table: "Artigo",
                column: "Pessoa_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artigo");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
