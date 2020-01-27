using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class TrobleshootDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc68d94a-3e1f-4ae2-8ed8-7eeaf002569e", "AQAAAAEAACcQAAAAEP5BtC7jJurmj7Om1Nkah2VArqdfYefgVBKRlUl8ARYpKKrr7Epk0pXXx0YYvF2S2Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47c342a6-6da4-4f9d-9834-0252b6cb51c5", "AQAAAAEAACcQAAAAEMgzAGF65ZT9xNCwoXjw8MexwfzQYQIKycs7LnQtW6ZbptMspFIcE+BZPFiOO5W12w==" });
        }
    }
}
