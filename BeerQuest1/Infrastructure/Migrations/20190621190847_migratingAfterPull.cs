using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class migratingAfterPull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentRank",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Members",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_RankId",
                table: "Members",
                column: "RankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Ranks_RankId",
                table: "Members",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Ranks_RankId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropIndex(
                name: "IX_Members_RankId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CurrentRank",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Members");
        }
    }
}
