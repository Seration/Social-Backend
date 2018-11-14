using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingAPI.Migrations
{
    public partial class AddedPublicIdX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicID",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicID",
                table: "Photos");
        }
    }
}
