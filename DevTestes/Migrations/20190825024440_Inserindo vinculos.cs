using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTestes.Migrations
{
    public partial class Inserindovinculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Funcionario",
                table: "BugProblemas");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "BugProblemas");

            migrationBuilder.DropColumn(
                name: "Sprint",
                table: "BugProblemas");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "BugProblemas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "BugProblemas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SprintId",
                table: "BugProblemas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BugProblemas_FuncionarioId",
                table: "BugProblemas",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BugProblemas_ProdutoId",
                table: "BugProblemas",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_BugProblemas_SprintId",
                table: "BugProblemas",
                column: "SprintId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugProblemas_Funcionario_FuncionarioId",
                table: "BugProblemas",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "AnalistaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugProblemas_Produtos_ProdutoId",
                table: "BugProblemas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugProblemas_Sprints_SprintId",
                table: "BugProblemas",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "SprintId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugProblemas_Funcionario_FuncionarioId",
                table: "BugProblemas");

            migrationBuilder.DropForeignKey(
                name: "FK_BugProblemas_Produtos_ProdutoId",
                table: "BugProblemas");

            migrationBuilder.DropForeignKey(
                name: "FK_BugProblemas_Sprints_SprintId",
                table: "BugProblemas");

            migrationBuilder.DropIndex(
                name: "IX_BugProblemas_FuncionarioId",
                table: "BugProblemas");

            migrationBuilder.DropIndex(
                name: "IX_BugProblemas_ProdutoId",
                table: "BugProblemas");

            migrationBuilder.DropIndex(
                name: "IX_BugProblemas_SprintId",
                table: "BugProblemas");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "BugProblemas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "BugProblemas");

            migrationBuilder.DropColumn(
                name: "SprintId",
                table: "BugProblemas");

            migrationBuilder.AddColumn<string>(
                name: "Funcionario",
                table: "BugProblemas",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Produto",
                table: "BugProblemas",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sprint",
                table: "BugProblemas",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }
    }
}
