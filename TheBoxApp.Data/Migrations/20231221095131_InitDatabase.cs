using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TheBoxApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DashBoardProperties",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    context = table.Column<string>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoardProperties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Ip = table.Column<string>(type: "text", nullable: true),
                    Mac = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Os = table.Column<string>(type: "text", nullable: true),
                    OsVersion = table.Column<string>(type: "text", nullable: true),
                    OsArchitecture = table.Column<string>(type: "text", nullable: true),
                    OsSerialNumber = table.Column<string>(type: "text", nullable: true),
                    OsLicenseKey = table.Column<string>(type: "text", nullable: true),
                    OsLicenseExpDate = table.Column<string>(type: "text", nullable: true),
                    OsLicenseExpStatus = table.Column<string>(type: "text", nullable: true),
                    OsLicenseType = table.Column<string>(type: "text", nullable: true),
                    OsLicenseStatus = table.Column<string>(type: "text", nullable: true),
                    OsLicenseNotes = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendor = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorContact = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorEmail = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorPhone = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorWebsite = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorNotes = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportExpDate = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportExpStatus = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportType = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportStatus = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportNotes = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendor = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorContact = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorEmail = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorPhone = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorWebsite = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorNotes = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorSupportExpDate = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorSupportExpStatus = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorSupportType = table.Column<string>(type: "text", nullable: true),
                    OsLicenseVendorSupportVendorSupport = table.Column<string>(type: "text", nullable: true),
                    MachineDashBoardPropertiesid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_DashBoardProperties_MachineDashBoardPropertiesid",
                        column: x => x.MachineDashBoardPropertiesid,
                        principalTable: "DashBoardProperties",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Machines_MachineDashBoardPropertiesid",
                table: "Machines",
                column: "MachineDashBoardPropertiesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "DashBoardProperties");
        }
    }
}
