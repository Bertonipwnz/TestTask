using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskUWP.Migrations
{
    public partial class ThreeMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type_Transaction",
                table: "Transaction",
                newName: "type_Transaction");

            migrationBuilder.RenameColumn(
                name: "Date_and_Time_Transaction",
                table: "Transaction",
                newName: "date_and_Time_Transaction");

            migrationBuilder.RenameColumn(
                name: "Comment_Transaction",
                table: "Transaction",
                newName: "comment_Transaction");

            migrationBuilder.RenameColumn(
                name: "Category_Transaction",
                table: "Transaction",
                newName: "category_Transaction");

            migrationBuilder.RenameColumn(
                name: "Amount_Transaction",
                table: "Transaction",
                newName: "amount_Transaction");

            migrationBuilder.RenameColumn(
                name: "ID_Transaction",
                table: "Transaction",
                newName: "id_Transaction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type_Transaction",
                table: "Transaction",
                newName: "Type_Transaction");

            migrationBuilder.RenameColumn(
                name: "date_and_Time_Transaction",
                table: "Transaction",
                newName: "Date_and_Time_Transaction");

            migrationBuilder.RenameColumn(
                name: "comment_Transaction",
                table: "Transaction",
                newName: "Comment_Transaction");

            migrationBuilder.RenameColumn(
                name: "category_Transaction",
                table: "Transaction",
                newName: "Category_Transaction");

            migrationBuilder.RenameColumn(
                name: "amount_Transaction",
                table: "Transaction",
                newName: "Amount_Transaction");

            migrationBuilder.RenameColumn(
                name: "id_Transaction",
                table: "Transaction",
                newName: "ID_Transaction");
        }
    }
}
