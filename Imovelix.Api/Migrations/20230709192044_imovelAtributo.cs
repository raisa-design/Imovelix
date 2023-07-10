using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imovelix.Api.Migrations
{
    /// <inheritdoc />
    public partial class imovelAtributo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Imovel",
                table: "Anuncios",
                newName: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_ImovelId",
                table: "Anuncios",
                column: "ImovelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncios_Imoveis_ImovelId",
                table: "Anuncios",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncios_Imoveis_ImovelId",
                table: "Anuncios");

            migrationBuilder.DropIndex(
                name: "IX_Anuncios_ImovelId",
                table: "Anuncios");

            migrationBuilder.RenameColumn(
                name: "ImovelId",
                table: "Anuncios",
                newName: "Imovel");
        }
    }
}
