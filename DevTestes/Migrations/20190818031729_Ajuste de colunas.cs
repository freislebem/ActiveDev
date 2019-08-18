using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTestes.Migrations
{
    public partial class Ajustedecolunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(20)",
                table: "BugProblemas",
                newName: "Produto");

            migrationBuilder.RenameColumn(
                name: "varchar(30)",
                table: "BugProblemas",
                newName: "Funcionario");

            migrationBuilder.RenameColumn(
                name: "varchar(6)",
                table: "BugProblemas",
                newName: "Chamado");

            migrationBuilder.AlterColumn<string>(
                name: "Produto",
                table: "BugProblemas",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Funcionario",
                table: "BugProblemas",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Chamado",
                table: "BugProblemas",
                type: "varchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sprint",
                table: "BugProblemas",
                type: "varchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sprint",
                table: "BugProblemas");

            migrationBuilder.RenameColumn(
                name: "Produto",
                table: "BugProblemas",
                newName: "varchar(20)");

            migrationBuilder.RenameColumn(
                name: "Funcionario",
                table: "BugProblemas",
                newName: "varchar(30)");

            migrationBuilder.RenameColumn(
                name: "Chamado",
                table: "BugProblemas",
                newName: "varchar(6)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(20)",
                table: "BugProblemas",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(30)",
                table: "BugProblemas",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(6)",
                table: "BugProblemas",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldNullable: true);
        }
    }
}
