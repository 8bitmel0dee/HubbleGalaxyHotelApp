using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class UpdatedRoomDescription2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b53d1f5-ddd5-466a-9ee5-822ccb753b72", "AQAAAAEAACcQAAAAEHXA0tvQ8At1q18wsxRbTpRQo6X+dSrGe8NYvs2qlYNQWm2vZQP8gF0a0C0cphyKxA==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoomDescription",
                value: "Replica of NASA's Gemini capsule");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "PricePerNight",
                value: 200.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b463308-9336-48d5-b34a-6bb98fe4edb6", "AQAAAAEAACcQAAAAEDZWbEejTxwIle1XTGLzJD8WH9v3BtMSm9LwrZY8nOrMyYWTlKVvZ4duqfNfDt7qSA==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoomDescription",
                value: "Replica Gemini capsule bed");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "PricePerNight",
                value: 100.0);
        }
    }
}
