using Microsoft.EntityFrameworkCore.Migrations;
using System;


namespace Infrastructure.Migrations
{
    public partial class _13377 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("SET Identity_Insert Teams ON INSERT INTO Teams (Id, Name) VALUES (2, 'Dallas Cowboys')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
