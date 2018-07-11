using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Redditv2.Migrations
{
    public partial class TimeStamp_columntype_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Timestamp",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(TimeSpan));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Timestamp",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
