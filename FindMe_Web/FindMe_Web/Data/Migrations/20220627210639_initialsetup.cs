using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindMe_Web.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissingPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastSeen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysMissing = table.Column<int>(type: "int", nullable: false),
                    MoreInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
