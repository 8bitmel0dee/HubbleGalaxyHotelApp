using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class UpdatedRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cc428e3-5b2b-4b80-b36a-1448f28f9921", "AQAAAAEAACcQAAAAEOb3bV/ye4wUEwMLu2Ikz8mHs+bmOziBVQj4OOZXUWGuqQaxRcxbsvYXSjYXDTEXdg==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RoomDescription", "RoomName" },
                values: new object[] { "Room Service to Major Tom", "Galaxy Pod" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94e96b5d-da3f-4d66-ab17-33f93bb87cb8", "AQAAAAEAACcQAAAAEFo+sCR47fg3+ykBp/DD+vl2R37ompbdmJVSZ8mn/QDhEAHXAXAwQqlD3Y3M1oFZBQ==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RoomDescription", "RoomName" },
                values: new object[] { "A Galaxy Room", "Galaxy Room" });
        }
    }
}
