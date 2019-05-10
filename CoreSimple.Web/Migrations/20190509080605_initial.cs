using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreSimple.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillsItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Market = table.Column<string>(nullable: true),
                    Shop = table.Column<string>(nullable: true),
                    ProductNoName = table.Column<string>(nullable: true),
                    ProductNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillsItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashFlows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Increase = table.Column<decimal>(nullable: false),
                    Reduce = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashFlows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "BillsItems");

            migrationBuilder.DropTable(
                name: "CashFlows");
        }
    }
}
