using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class newDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Disciplina_DisciplinaId",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "Aprexplcdiversao",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Avaliacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Disciplina_DisciplinaId",
                table: "Avaliacao",
                column: "DisciplinaId",
                principalTable: "Disciplina",
                principalColumn: "DisciplinaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Disciplina_DisciplinaId",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Aprexplcdiversao",
                table: "Avaliacao",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Avaliacao",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Disciplina_DisciplinaId",
                table: "Avaliacao",
                column: "DisciplinaId",
                principalTable: "Disciplina",
                principalColumn: "DisciplinaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
