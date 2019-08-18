using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTestes.Migrations
{
    public partial class Ajustedacolunaimpacto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Impacto",
                table: "BugProblemas",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Impacto",
                table: "BugProblemas",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);
        }
    }
}
