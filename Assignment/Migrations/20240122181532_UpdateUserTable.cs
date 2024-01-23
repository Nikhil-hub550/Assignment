using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobby_Users_UserId",
                table: "Hobby");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRole_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hobby",
                table: "Hobby");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "Hobby",
                newName: "Hobbies");

            migrationBuilder.RenameIndex(
                name: "IX_Hobby_UserId",
                table: "Hobbies",
                newName: "IX_Hobbies_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hobbies",
                table: "Hobbies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleGroupId",
                schema: "master",
                table: "Users",
                column: "RoleGroupId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleGroupId",
                schema: "master",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hobbies",
                table: "Hobbies");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Hobbies",
                newName: "Hobby");

            migrationBuilder.RenameIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobby",
                newName: "IX_Hobby_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hobby",
                table: "Hobby",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleGroupId",
                schema: "master",
                table: "Users",
                column: "RoleGroupId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hobby_Users_UserId",
                table: "Hobby",
                column: "UserId",
                principalSchema: "master",
                principalTable: "Users",
                principalColumn: "UserNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRole_RoleGroupId",
                schema: "master",
                table: "Users",
                column: "RoleGroupId",
                principalTable: "UserRole",
                principalColumn: "Id");
        }
    }
}
