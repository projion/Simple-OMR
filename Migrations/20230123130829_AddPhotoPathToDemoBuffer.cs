using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_OMR.Migrations
{
    public partial class AddPhotoPathToDemoBuffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photopath",
                table: "demoBufferModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photopath",
                table: "demoBufferModels");
        }
    }
}
