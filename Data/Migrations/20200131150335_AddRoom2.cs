using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class AddRoom2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b4c6a7-30fb-4a45-98f3-968f52e68840", "AQAAAAEAACcQAAAAELNhDpBcq3nA8oMiUpEbDdXU4/UhPZw473q5BHvVaGl5ngRjqzdoFw3bwrl44/34JA==" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "ApplicationUserId", "PricePerNight", "RoomDescription", "RoomFeatures", "RoomImage", "RoomName", "UserId" },
                values: new object[] { 2, null, 200.0, "Nebula ceiling", "Zero gravity capsule", "Image URL", "Hubble Galaxy Suite", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5647cf06-5b60-4777-a318-f5d62204fec0", "AQAAAAEAACcQAAAAED8UpXZSPvSS5CHHK/vxqrEaJ74kKeRicIt1/pDv+SqejH6Dv/IZiyyzgLr1nluS7g==" });
        }
    }
}
