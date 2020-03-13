using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JMarshall_ProgrammingChallenge1.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 3,
                column: "dateAdded",
                value: new DateTime(2020, 2, 16, 13, 49, 47, 360, DateTimeKind.Local).AddTicks(8459));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 3,
                column: "dateAdded",
                value: new DateTime(2020, 2, 16, 13, 27, 35, 710, DateTimeKind.Local).AddTicks(4646));
        }
    }
}
