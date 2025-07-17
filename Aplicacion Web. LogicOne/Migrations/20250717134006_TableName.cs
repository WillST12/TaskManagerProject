using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion_Web._LogicOne.Migrations
{
    /// <inheritdoc />
    public partial class TableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks_DB",
                table: "Tasks_DB");

            migrationBuilder.RenameTable(
                name: "Tasks_DB",
                newName: "Tasks_Table");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks_Table",
                table: "Tasks_Table",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks_Table",
                table: "Tasks_Table");

            migrationBuilder.RenameTable(
                name: "Tasks_Table",
                newName: "Tasks_DB");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks_DB",
                table: "Tasks_DB",
                column: "ID");
        }
    }
}
