using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsType = table.Column<int>(type: "int", nullable: false),
                    NewsText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsAttachements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsLanguage = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolId);
                    table.ForeignKey(
                        name: "FK_Schools_Newses_NewsId",
                        column: x => x.NewsId,
                        principalTable: "Newses",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_NewsId",
                table: "Schools",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Newses");
        }
    }
}
