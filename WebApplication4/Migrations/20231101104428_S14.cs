using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KipperPro.API_ASP_CORE.Migrations
{
    /// <inheritdoc />
    public partial class S14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Visitors");

            migrationBuilder.RenameColumn(
                name: "PassportSerua",
                table: "Visitors",
                newName: "Passport");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "Visitors",
                newName: "PassportSerua");

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
