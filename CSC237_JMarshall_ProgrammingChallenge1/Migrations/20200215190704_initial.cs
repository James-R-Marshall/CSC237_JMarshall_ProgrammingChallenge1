using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JMarshall_ProgrammingChallenge1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactID);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contactID", "firstName", "lastName", "phone" },
                values: new object[] { 1, "James", "marshall", "720-965-1983" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contactID", "firstName", "lastName", "phone" },
                values: new object[] { 2, "Philip", "marshall", "720-965-2248" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "contactID", "firstName", "lastName", "phone" },
                values: new object[] { 3, "Sarah", "marshall", "720-965-1111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
