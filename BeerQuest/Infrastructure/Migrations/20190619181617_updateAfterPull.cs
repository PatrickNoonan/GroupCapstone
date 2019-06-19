using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class updateAfterPull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassportID",
                table: "Members",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_PassportID",
                table: "Members",
                column: "PassportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Passports_PassportID",
                table: "Members",
                column: "PassportID",
                principalTable: "Passports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Passports_PassportID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_PassportID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "PassportID",
                table: "Members");
        }
    }
}
