using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LimedikosTask.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameLogsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Error",
                table: "Error");

            migrationBuilder.RenameTable(
                name: "Error",
                newName: "Logs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logs",
                table: "Logs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logs",
                table: "Logs");

            migrationBuilder.RenameTable(
                name: "Logs",
                newName: "Error");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Error",
                table: "Error",
                column: "Id");
        }
    }
}
