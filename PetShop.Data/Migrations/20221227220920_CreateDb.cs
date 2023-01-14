using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(nullable: false),
                    ProductStoke = table.Column<int>(nullable: false),
                    ProductPrice = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(maxLength: 50, nullable: false),
                    ServicePrice = table.Column<int>(nullable: false),
                    ServiceDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Adopters",
                columns: table => new
                {
                    AdopterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdopterName = table.Column<string>(maxLength: 50, nullable: false),
                    AdopterAge = table.Column<int>(nullable: false),
                    AdopterAdress = table.Column<string>(maxLength: 50, nullable: false),
                    AdopterPhone = table.Column<string>(maxLength: 11, nullable: false),
                    ServiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopters", x => x.AdopterID);
                    table.ForeignKey(
                        name: "FK_Adopters_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerName = table.Column<string>(maxLength: 50, nullable: false),
                    VolunteerAge = table.Column<int>(nullable: false),
                    VolunteerPhone = table.Column<string>(maxLength: 11, nullable: false),
                    VolunteerAdress = table.Column<string>(maxLength: 50, nullable: true),
                    ServiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.VolunteerID);
                    table.ForeignKey(
                        name: "FK_Volunteers_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalType = table.Column<string>(maxLength: 50, nullable: false),
                    AnimalGender = table.Column<string>(nullable: false),
                    AnimalAge = table.Column<int>(nullable: false),
                    AdopterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalID);
                    table.ForeignKey(
                        name: "FK_Animals_Adopters_AdopterID",
                        column: x => x.AdopterID,
                        principalTable: "Adopters",
                        principalColumn: "AdopterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adopters_ServiceID",
                table: "Adopters",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AdopterID",
                table: "Animals",
                column: "AdopterID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_ServiceID",
                table: "Volunteers",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Adopters");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
