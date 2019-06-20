using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopFourId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopOneId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopThreeId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopTwoId",
                table: "Passports");

            migrationBuilder.AlterColumn<int>(
                name: "StopTwoId",
                table: "Passports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StopThreeId",
                table: "Passports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StopOneId",
                table: "Passports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StopFourId",
                table: "Passports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopFourId",
                table: "Passports",
                column: "StopFourId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopOneId",
                table: "Passports",
                column: "StopOneId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopThreeId",
                table: "Passports",
                column: "StopThreeId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopTwoId",
                table: "Passports",
                column: "StopTwoId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopFourId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopOneId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopThreeId",
                table: "Passports");

            migrationBuilder.DropForeignKey(
                name: "FK_Passports_Stops_StopTwoId",
                table: "Passports");

            migrationBuilder.AlterColumn<int>(
                name: "StopTwoId",
                table: "Passports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StopThreeId",
                table: "Passports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StopOneId",
                table: "Passports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StopFourId",
                table: "Passports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopFourId",
                table: "Passports",
                column: "StopFourId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopOneId",
                table: "Passports",
                column: "StopOneId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopThreeId",
                table: "Passports",
                column: "StopThreeId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Passports_Stops_StopTwoId",
                table: "Passports",
                column: "StopTwoId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
