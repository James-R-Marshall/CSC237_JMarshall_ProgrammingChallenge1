using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JMarshall_ProgrammingChallenge1.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateAdded",
                table: "Contacts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "organization",
                table: "Contacts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 1,
                columns: new[] { "dateAdded", "organization" },
                values: new object[] { new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "NONE" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 2,
                columns: new[] { "dateAdded", "organization" },
                values: new object[] { new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Cresco" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 3,
                column: "dateAdded",
                value: new DateTime(2020, 2, 16, 13, 27, 35, 710, DateTimeKind.Local).AddTicks(4646));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateAdded",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "organization",
                table: "Contacts");
        }
    }
}
