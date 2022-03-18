using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "SchoolName" },
                values: new object[] { 1, "Al manarath/Al Khobar" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "SchoolName" },
                values: new object[] { 2, "Al Faisaliyah Islamic International" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2);
        }
    }
}
