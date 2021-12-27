using Microsoft.EntityFrameworkCore.Migrations;

namespace StaySafeHotels.Migrations
{
    public partial class hotelroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelHasRoomTypes_Hotels_HotelId",
                table: "HotelHasRoomTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelHasRoomTypes_RoomTypes_RoomTypeID",
                table: "HotelHasRoomTypes");

            migrationBuilder.AlterColumn<int>(
                name: "RoomTypeID",
                table: "HotelHasRoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "HotelHasRoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHasRoomTypes_Hotels_HotelId",
                table: "HotelHasRoomTypes",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHasRoomTypes_RoomTypes_RoomTypeID",
                table: "HotelHasRoomTypes",
                column: "RoomTypeID",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelHasRoomTypes_Hotels_HotelId",
                table: "HotelHasRoomTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelHasRoomTypes_RoomTypes_RoomTypeID",
                table: "HotelHasRoomTypes");

            migrationBuilder.AlterColumn<int>(
                name: "RoomTypeID",
                table: "HotelHasRoomTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "HotelHasRoomTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHasRoomTypes_Hotels_HotelId",
                table: "HotelHasRoomTypes",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHasRoomTypes_RoomTypes_RoomTypeID",
                table: "HotelHasRoomTypes",
                column: "RoomTypeID",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
