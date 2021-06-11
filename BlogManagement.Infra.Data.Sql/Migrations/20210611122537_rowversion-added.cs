using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogManagement.Infra.Data.Sql.Migrations
{
    public partial class rowversionadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Post",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Comment",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Blog",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Blog");
        }
    }
}
