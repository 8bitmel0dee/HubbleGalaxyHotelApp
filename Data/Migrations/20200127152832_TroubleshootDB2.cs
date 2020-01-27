using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class TroubleshootDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5647cf06-5b60-4777-a318-f5d62204fec0", "AQAAAAEAACcQAAAAED8UpXZSPvSS5CHHK/vxqrEaJ74kKeRicIt1/pDv+SqejH6Dv/IZiyyzgLr1nluS7g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc68d94a-3e1f-4ae2-8ed8-7eeaf002569e", "AQAAAAEAACcQAAAAEP5BtC7jJurmj7Om1Nkah2VArqdfYefgVBKRlUl8ARYpKKrr7Epk0pXXx0YYvF2S2Q==" });
        }
    }
}
