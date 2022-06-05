using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskUWP.Migrations
{
    public partial class CreateTableTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    id_Transaction = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    amount_Money = table.Column<int>(nullable: false),
                    amount_Transaction = table.Column<int>(maxLength: 10, nullable: false),
                    category_Transaction = table.Column<string>(nullable: false),
                    comment_Transaction = table.Column<string>(maxLength: 30, nullable: true),
                    date_and_Time_Transaction = table.Column<DateTime>(nullable: false),
                    type_Transaction = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.id_Transaction);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
