using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion_Web._LogicOne.Migrations
{
    /// <inheritdoc />
    public partial class DBfieldsReWrite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Tasks_Table",
                newName: "FechaCreacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Tasks_Table",
                newName: "DateTime");
        }
    }
}
