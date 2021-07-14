using Microsoft.EntityFrameworkCore.Migrations;

namespace Seccion_17_EFC.Migrations
{
    public partial class AddEntidaesAutoryAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Canciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Canciones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Canciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Canciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Albumes",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumes", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AutorId",
                table: "Canciones",
                column: "AutorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Albumes_AlbumId",
                table: "Canciones",
                column: "AlbumId",
                principalTable: "Albumes",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Autores_AutorId",
                table: "Canciones",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Albumes_AlbumId",
                table: "Canciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Autores_AutorId",
                table: "Canciones");

            migrationBuilder.DropTable(
                name: "Albumes");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AutorId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Canciones");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Canciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Canciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
