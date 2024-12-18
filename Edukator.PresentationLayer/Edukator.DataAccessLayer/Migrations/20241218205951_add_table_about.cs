using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class add_table_about : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
