using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KipperPro.API_ASP_CORE.Migrations
{
    /// <inheritdoc />
    public partial class S12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Users");
        }
    }
}
