using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPTB2.Server.Data.Migrations
{
    public partial class Configs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserID",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PayID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateIn", "DateOut", "DateUpdated", "TotalCost", "UpdatedBy", "UserID", "UsersId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(5725), "$70.00", "System", 0, null },
                    { 2, "System", new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(5731), "$76.00", "System", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CardNumber", "CreatedBy", "DateCreated", "DateOfExpiry", "DateUpdated", "Name", "SecurityCode", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "2563 6143 3434 8172", "System", new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(1523), "Tan Ping Jing", "465", "System" },
                    { 2, "6363 5261 9765 0162", "System", new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(1528), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 1, 57, 380, DateTimeKind.Local).AddTicks(1530), "Arnold Schwarzenegger", "816", "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Text", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 5, 15, 1, 57, 379, DateTimeKind.Local).AddTicks(6698), new DateTime(2023, 2, 5, 15, 1, 57, 379, DateTimeKind.Local).AddTicks(6713), "DickRooster", "The trip was fun and interactive. I thoroughly enjoyed myself at many point of interests, would recommend to anyone who is interested in visiting the country.", "System" },
                    { 2, "System", new DateTime(2023, 2, 5, 15, 1, 57, 379, DateTimeKind.Local).AddTicks(6717), new DateTime(2023, 2, 5, 15, 1, 57, 379, DateTimeKind.Local).AddTicks(6719), "ArnoldSchwarzenegger", "The trip was not as great as I had expected. The points of interest did not look as good as they were on paper, so don't get your hopes up too much if you are planning to buy it. 5/10 overall.", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PayID", "ReviewID" },
                values: new object[] { new DateTime(2023, 2, 5, 15, 1, 57, 376, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 2, 5, 15, 1, 57, 377, DateTimeKind.Local).AddTicks(5517), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PayID", "ReviewID" },
                values: new object[] { new DateTime(2023, 2, 5, 15, 1, 57, 377, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 2, 5, 15, 1, 57, 377, DateTimeKind.Local).AddTicks(6423), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UsersId",
                table: "Bookings",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UsersId",
                table: "Bookings",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UsersId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UsersId",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PayID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PayID", "ReviewID" },
                values: new object[] { new DateTime(2023, 2, 5, 2, 40, 55, 823, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(8704), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PayID", "ReviewID" },
                values: new object[] { new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(9661), 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserID",
                table: "Bookings",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserID",
                table: "Bookings",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
