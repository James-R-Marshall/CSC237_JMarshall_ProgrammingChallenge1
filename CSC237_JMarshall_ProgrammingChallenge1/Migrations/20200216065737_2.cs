using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_JMarshall_ProgrammingChallenge1.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Contacts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "categoryName" },
                values: new object[,]
                {
                    { 1, "family" },
                    { 2, "friend" },
                    { 3, "Work" },
                    { 4, "N/A" }
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 1,
                columns: new[] { "CategoryID", "email" },
                values: new object[] { 2, "james_marshall48@aol.com" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 2,
                columns: new[] { "CategoryID", "email" },
                values: new object[] { 1, "philip.marshall123456789@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "contactID",
                keyValue: 3,
                columns: new[] { "CategoryID", "email" },
                values: new object[] { 1, "sarah.carpenteyro@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Categories_CategoryID",
                table: "Contacts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Categories_CategoryID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
