using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class addunique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeArea",
                table: "Area",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Area_NomeArea",
                table: "Area",
                column: "NomeArea",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Area_NomeArea",
                table: "Area");

            migrationBuilder.AlterColumn<string>(
                name: "NomeArea",
                table: "Area",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
