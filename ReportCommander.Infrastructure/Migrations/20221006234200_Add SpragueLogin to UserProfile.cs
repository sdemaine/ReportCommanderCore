using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportCommander.Infrastructure.Migrations
{
    public partial class AddSpragueLogintoUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpragueLogin",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpragueLogin",
                table: "UserProfiles");
        }
    }
}
