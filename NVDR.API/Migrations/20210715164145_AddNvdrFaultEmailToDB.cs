using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NVDR.API.Migrations
{
    public partial class AddNvdrFaultEmailToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NvdrFaultEmails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NvdrDeviceId = table.Column<long>(type: "bigint", nullable: false),
                    EmailTo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailCC = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailBCC = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailBody = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EmailTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderIP = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NvdrFaultEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NvdrFaultEmails_NvdrRecords_NvdrDeviceId",
                        column: x => x.NvdrDeviceId,
                        principalTable: "NvdrRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NvdrFaultEmails_NvdrDeviceId",
                table: "NvdrFaultEmails",
                column: "NvdrDeviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NvdrFaultEmails");
        }
    }
}
