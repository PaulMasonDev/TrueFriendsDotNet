using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueFriendsDotNet.DataAccess.Migrations
{
    public partial class AddFriendsToDbChangeFriendIdToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FriendId",
                table: "Friends",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Friends",
                newName: "FriendId");
        }
    }
}
