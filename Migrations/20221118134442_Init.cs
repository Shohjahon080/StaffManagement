using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StaffManagement.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<int>(type: "integer", nullable: false),
                    PhotoFilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "Id", "Department", "Email", "FirstName", "LastName", "PhotoFilePath" },
                values: new object[,]
                {
                    { 1, 1, "shoh@gmail.com", "Shohjahon", "Normuminov", null },
                    { 2, 2, "timati@gmail.com", "Temur", "Oybekov", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffs");
        }
    }
}
