using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class UniqueAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CpfProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomeDisciplina",
                table: "Disciplina",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Professor_CpfProfessor",
                table: "Professor",
                column: "CpfProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_EmailProfessor",
                table: "Professor",
                column: "EmailProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_NomeProfessor",
                table: "Professor",
                column: "NomeProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_NomeDisciplina",
                table: "Disciplina",
                column: "NomeDisciplina",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_NomeCurso",
                table: "Curso",
                column: "NomeCurso",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Professor_CpfProfessor",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_EmailProfessor",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_NomeProfessor",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Disciplina_NomeDisciplina",
                table: "Disciplina");

            migrationBuilder.DropIndex(
                name: "IX_Curso_NomeCurso",
                table: "Curso");

            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CpfProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomeDisciplina",
                table: "Disciplina",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
