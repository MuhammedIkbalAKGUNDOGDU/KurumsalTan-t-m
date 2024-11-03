using Microsoft.EntityFrameworkCore.Migrations;

namespace KurumsalTanıtım.Migrations
{
    public partial class initHizmetAl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hizmetals",
                columns: table => new
                {
                    HizmetAlId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IlveIlce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    TemizlikSikligi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetals", x => x.HizmetAlId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hizmetals");
        }
    }
}
