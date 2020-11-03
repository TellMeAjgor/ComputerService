using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerServiceMainApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ComputerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpu = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    Gpu = table.Column<string>(nullable: true),
                    Case = table.Column<string>(nullable: true),
                    Psu = table.Column<int>(nullable: false),
                    Motherboard = table.Column<string>(nullable: true),
                    Os = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ComputerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
