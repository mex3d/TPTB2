using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPTB2.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfExpiry",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TotalCost",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "PayID", "PaymentId", "ReviewID", "ReviewsId", "UpdatedBy", "Username" },
                values: new object[] { 1, "99999998", "System", new DateTime(2023, 2, 5, 2, 40, 55, 823, DateTimeKind.Local).AddTicks(3469), "22.03.1969", new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(8704), "FloppyDisk@gmail.com", 0, null, 0, null, "System", "DickRooster" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "PayID", "PaymentId", "ReviewID", "ReviewsId", "UpdatedBy", "Username" },
                values: new object[] { 2, "99999997", "System", new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(9656), "30.07.1947", new DateTime(2023, 2, 5, 2, 40, 55, 826, DateTimeKind.Local).AddTicks(9661), "GigaChad@gmail.com", 0, null, 0, null, "System", "4rnoldSchwarzenegger" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateOfExpiry",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Description");

            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "TotalCost",
                table: "Bookings",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
