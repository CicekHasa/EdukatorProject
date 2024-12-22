using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class update_table_mail_to_mailsubscribes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.CreateTable(
                name: "MailSubscribes",
                columns: table => new
                {
                    MailSubscribeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailSubscribes", x => x.MailSubscribeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailSubscribes");

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    MailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.MailID);
                });
        }
    }
}
