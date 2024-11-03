using Microsoft.EntityFrameworkCore.Migrations;

namespace KurumsalTanıtım.Migrations
{
    public partial class initIletisim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iletisims",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisims", x => x.IletisimId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_iletisims_Email",
                table: "iletisims",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iletisims");
        }
    }
}
