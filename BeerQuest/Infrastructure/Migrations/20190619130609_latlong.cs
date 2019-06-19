using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class latlong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Stops_CurrentBarId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Members_CurrentMemberId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_CurrentBarId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_CurrentMemberId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CurrentBarId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CurrentMemberId",
                table: "Messages");

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "Stops",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lng",
                table: "Stops",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "CurrentBar",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentMember",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "Businesses",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "lng",
                table: "Businesses",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "Stops");

            migrationBuilder.DropColumn(
                name: "lng",
                table: "Stops");

            migrationBuilder.DropColumn(
                name: "CurrentBar",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CurrentMember",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "lng",
                table: "Businesses");

            migrationBuilder.AddColumn<int>(
                name: "CurrentBarId",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentMemberId",
                table: "Messages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CurrentBarId",
                table: "Messages",
                column: "CurrentBarId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CurrentMemberId",
                table: "Messages",
                column: "CurrentMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Stops_CurrentBarId",
                table: "Messages",
                column: "CurrentBarId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Members_CurrentMemberId",
                table: "Messages",
                column: "CurrentMemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
