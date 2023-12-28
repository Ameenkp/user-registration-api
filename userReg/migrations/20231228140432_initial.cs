using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace userReg.migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APP_REG",
                columns: table => new
                {
                    APP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APP_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    APP_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_POSITION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    APP_AGE = table.Column<int>(type: "int", nullable: false),
                    APP_GENDER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_REASON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_NOYEARS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    APP_CURRENTEMPLOYER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APP_NP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APP_REG", x => x.APP_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APP_REG");
        }
    }
}
