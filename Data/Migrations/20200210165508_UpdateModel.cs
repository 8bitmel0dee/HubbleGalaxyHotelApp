using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bcba66d-5cf8-43c7-bf09-43d397f6ad9b", "AQAAAAEAACcQAAAAEMwL0MAMSi8X7JkwHvePY14/cpqu8AEuA1AO3ezXZQAFnJ9bBJSJShuYwnfQ+D3pFQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cc428e3-5b2b-4b80-b36a-1448f28f9921", "AQAAAAEAACcQAAAAEOb3bV/ye4wUEwMLu2Ikz8mHs+bmOziBVQj4OOZXUWGuqQaxRcxbsvYXSjYXDTEXdg==" });
        }
    }
}
