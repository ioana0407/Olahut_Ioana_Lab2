using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olahut_Ioana_Lab2.Migrations.LibraryIdentity
{
    /// <inheritdoc />
    public partial class CreateIdentitySchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetUserClaims",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetRoleClaims",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetUsers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetUserClaims",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetRoles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetRoleClaims",
                newName: "ID");
        }
    }
}
