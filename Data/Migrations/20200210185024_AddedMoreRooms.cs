using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class AddedMoreRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "RoomDescription",
                value: "Room Service to Major Tom.");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "ApplicationUserId", "PricePerNight", "RoomDescription", "RoomFeatures", "RoomImage", "RoomName", "UserId" },
                values: new object[,]
                {
                    { 3, null, 108.0, "Take a ride in this floor-to-ceiling rocket.", "A few friendly alien guests", "https://i.imgur.com/P26tsGG.jpg", "Whimsical Red Spaceship", null },
                    { 4, null, 236.0, "Experience the feeling of flying among the stars.", "Triangular whirlpool bath that glows softly under the stars. Steam shower. Wet bar.", "https://i.imgur.com/4v2J8y5.jpg", "Space Odyssey Suite", null },
                    { 5, null, 182.0, "Sleep in a giant crater dressed with astronaut spacesuit bedding as you look up to the planets and stars above.", "Voyages for little ones in a mini-rocket. In-room telescope. Sea-view balcony.", "https://i.imgur.com/leY3lUu.png", "Outer Space Room", null },
                    { 6, null, 150.0, "Replica Gemini capsule bed", "Oversized “moon crater” whirlpool", "https://i.imgur.com/FHsPwrE.jpg", "Gemini Space Capsule", null },
                    { 7, null, 100.0, "Rooms are so yesterday. Stay in a sleeping capsule!", "Staffed by friendly robots", "https://i.imgur.com/zU3b0vF.jpg", "Futuristic Space Capsule", null },
                    { 8, null, 1600.0, "Decorated with an ultimate commitment to extraterrestrial design, this stunning room makes you feel transported straight to the moon.", "King-size bed designed to look like it is floating in the air. Inspired by the movie 2001.", "https://i.imgur.com/x6YoYWX.jpg", "Liquid Gravity Moon Suite", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bcba66d-5cf8-43c7-bf09-43d397f6ad9b", "AQAAAAEAACcQAAAAEMwL0MAMSi8X7JkwHvePY14/cpqu8AEuA1AO3ezXZQAFnJ9bBJSJShuYwnfQ+D3pFQ==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomDescription",
                value: "Room Service to Major Tom");
        }
    }
}
