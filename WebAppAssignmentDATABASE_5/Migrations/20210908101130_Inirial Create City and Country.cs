using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAssignmentDATABASE_5.Migrations
{
    public partial class InirialCreateCityandCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonCity",
                table: "Peoples");

            migrationBuilder.AddColumn<int>(
                name: "PersonCityCityId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountryCityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryCityId",
                        column: x => x.CountryCityId,
                        principalTable: "Countries",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_PersonCityCityId",
                table: "Peoples",
                column: "PersonCityCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryCityId",
                table: "Cities",
                column: "CountryCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Cities_PersonCityCityId",
                table: "Peoples",
                column: "PersonCityCityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Cities_PersonCityCityId",
                table: "Peoples");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_PersonCityCityId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "PersonCityCityId",
                table: "Peoples");

            migrationBuilder.AddColumn<string>(
                name: "PersonCity",
                table: "Peoples",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
