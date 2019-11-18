using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class trampoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroQuestao",
                table: "Questoes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroQuestao",
                table: "Questoes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
