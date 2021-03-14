using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueFriendsDotNet.DataAccess.Migrations
{
    public partial class addlastnametofriendstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Friends",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Friends",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Friends");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Friends",
                newName: "Name");
        }
    }
}
