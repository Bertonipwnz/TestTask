using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskUWP.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount_Transaction",
                table: "Transaction",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category_Transaction",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment_Transaction",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_and_Time_Transaction",
                table: "Transaction",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount_Transaction",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Category_Transaction",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Comment_Transaction",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Date_and_Time_Transaction",
                table: "Transaction");
        }
    }
}
