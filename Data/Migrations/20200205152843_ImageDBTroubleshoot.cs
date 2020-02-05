using Microsoft.EntityFrameworkCore.Migrations;

namespace HubbleGalaxyHotelApp.Data.Migrations
{
    public partial class ImageDBTroubleshoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "RoomImage",
                value: "https://i.imgur.com/VbQIyjw.jpg");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomImage",
                value: "https://i.imgur.com/5whB7Zk.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b4c6a7-30fb-4a45-98f3-968f52e68840", "AQAAAAEAACcQAAAAELNhDpBcq3nA8oMiUpEbDdXU4/UhPZw473q5BHvVaGl5ngRjqzdoFw3bwrl44/34JA==" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomImage",
                value: "IMAGE URL");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomImage",
                value: "Image URL");
        }
    }
}
