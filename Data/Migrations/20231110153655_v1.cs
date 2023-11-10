using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitalisAPI.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_DOCTOR",
                columns: table => new
                {
                    CL_PK_IDENTIFY = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CL_FIRST_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CL_LAST_NAME = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    CL_EMAIL_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_PHONE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_CRM = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CL_SPECIALTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_ADDITIONAL_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_STATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_DISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_UNIT_FEDERATIVE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CL_ZIP_CODE = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DOCTOR", x => x.CL_PK_IDENTIFY);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DOCTOR");
        }
    }
}
