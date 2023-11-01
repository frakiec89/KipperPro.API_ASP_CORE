using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KipperPro.API_ASP_CORE.Migrations
{
    /// <inheritdoc />
    public partial class S13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "AttendsPersonally",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AttendsGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttendsPersonally_UserId",
                table: "AttendsPersonally",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendsGroups_UserId",
                table: "AttendsGroups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendsGroups_Users_UserId",
                table: "AttendsGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendsPersonally_Users_UserId",
                table: "AttendsPersonally",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendsGroups_Users_UserId",
                table: "AttendsGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendsPersonally_Users_UserId",
                table: "AttendsPersonally");

            migrationBuilder.DropIndex(
                name: "IX_AttendsPersonally_UserId",
                table: "AttendsPersonally");

            migrationBuilder.DropIndex(
                name: "IX_AttendsGroups_UserId",
                table: "AttendsGroups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AttendsGroups");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AttendsPersonally",
                newName: "Number");
        }
    }
}
