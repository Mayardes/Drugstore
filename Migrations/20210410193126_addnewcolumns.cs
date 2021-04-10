using Microsoft.EntityFrameworkCore.Migrations;

namespace drugstore.Migrations
{
    public partial class addnewcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Administrators",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Administrators");
        }
    }
}
