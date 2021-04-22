using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CompanyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Customers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Staff_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thickness = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, "Sander", "Coussement" },
                    { 1, "Jonas", "De Meyer" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "UnitId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Lopende meter", "lm" },
                    { 2, "Vierkante meter", "m²" },
                    { 3, "Kubieke meter", "m³" },
                    { 4, "Stuk", "st" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "PersonId", "CompanyNumber" },
                values: new object[] { 1, "0123456789" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("d55ae7cc-d7de-4a98-864a-4fac73336b7a"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("11cc6b49-0032-47ec-81cf-bb8e35497862"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("98ddecc3-e67d-4d89-9e1c-c3bd70871b4a"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("e76be890-52b3-47e7-b5c7-54eb47a724a8"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 },
                    { new Guid("b0792a04-404b-4d2d-b57c-06ac4cefc12e"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("f5dde93d-1b03-4513-b5cd-9f4d4a666828"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("c6b3b5c3-d446-4e35-9084-fa83a62eb2f2"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("bc98bde3-9d4c-49d2-b846-5fcc7ebb57ba"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("71839a16-d0ee-48df-9793-f4d448a0b70e"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("9f6c35ee-3c15-497a-aeee-110f825fbf0c"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("d4c86bc8-9809-4a29-b67e-b9f23084d712"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("7d21bbb5-00e6-4269-bc86-085382e58e9a"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("ab7129cf-be14-4550-b615-5127a9d998d6"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("c62f54e4-fe3c-4c24-ab01-0112ef2d620c"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("d35e2f98-1f40-4aee-a880-d23d2223ec0f"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("49403ced-8cfe-4b98-98d6-46766384ee38"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "PersonId", "Email", "IsAdmin", "TelephoneNumber" },
                values: new object[] { 2, null, true, "0412345678" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitId",
                table: "Products",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
