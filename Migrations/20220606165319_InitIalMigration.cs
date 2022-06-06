using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskUWP.Migrations
{
    public partial class InitIalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    IdTransaction = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    AmountMoney = table.Column<int>(nullable: false),
                    AmountTransaction = table.Column<int>(maxLength: 10, nullable: false),
                    CategoryTransaction = table.Column<string>(nullable: false),
                    CommentTransaction = table.Column<string>(maxLength: 30, nullable: true),
                    DateAndTimeTransaction = table.Column<DateTime>(nullable: false),
                    TypeTransaction = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.IdTransaction);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
