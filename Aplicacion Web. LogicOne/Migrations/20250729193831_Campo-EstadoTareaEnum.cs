using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion_Web._LogicOne.Migrations
{
    /// <inheritdoc />
    public partial class CampoEstadoTareaEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoTarea",
                table: "Tasks_Table",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoTarea",
                table: "Tasks_Table");
        }
    }
}
