using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoWithEF.Migrations
{
    public partial class assignee_class_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssigneeID",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assignees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignees", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssigneeID",
                table: "Todos",
                column: "AssigneeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignees_AssigneeID",
                table: "Todos",
                column: "AssigneeID",
                principalTable: "Assignees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignees_AssigneeID",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Assignees");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AssigneeID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssigneeID",
                table: "Todos");
        }
    }
}
