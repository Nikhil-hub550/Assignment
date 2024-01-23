using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class CascadeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies",
                column: "UserId",
                principalSchema: "master",
                principalTable: "Users",
                principalColumn: "UserNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleGroupId",
                schema: "master",
                table: "Users",
                column: "RoleGroupId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies",
                column: "UserId",
                principalSchema: "master",
                principalTable: "Users",
                principalColumn: "UserNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleGroupId",
                schema: "master",
                table: "Users",
                column: "RoleGroupId",
                principalTable: "UserRoles",
                principalColumn: "Id");
        }
    }
}
