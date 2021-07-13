using Microsoft.EntityFrameworkCore.Migrations;

namespace NVDR.API.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NvdrRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NvdrName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NvdrSerialNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NvdrDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NvdrRecords", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NvdrRecords");
        }
    }
}
