using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTestes.Migrations
{
    public partial class ArrumandoCampoChaveFuncionado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugProblemas_Funcionario_FuncionarioId",
                table: "BugProblemas");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "BugProblemas",
                newName: "AnalistaId");

            migrationBuilder.RenameIndex(
                name: "IX_BugProblemas_FuncionarioId",
                table: "BugProblemas",
                newName: "IX_BugProblemas_AnalistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugProblemas_Funcionario_AnalistaId",
                table: "BugProblemas",
                column: "AnalistaId",
                principalTable: "Funcionario",
                principalColumn: "AnalistaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugProblemas_Funcionario_AnalistaId",
                table: "BugProblemas");

            migrationBuilder.RenameColumn(
                name: "AnalistaId",
                table: "BugProblemas",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_BugProblemas_AnalistaId",
                table: "BugProblemas",
                newName: "IX_BugProblemas_FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugProblemas_Funcionario_FuncionarioId",
                table: "BugProblemas",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "AnalistaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
