using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class TestingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testing",
                columns: table => new
                {
                    TestingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TestingName = table.Column<string>(type: "TEXT", nullable: true),
                    TestingNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testing", x => x.TestingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testing");
        }
    }
}
