using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class initMigration2 : Migration
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
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerPersonId",
                        column: x => x.CustomerPersonId,
                        principalTable: "Customers",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersOrderId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("3ba258d9-f88b-4fc8-a1b0-bcacb1793533"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("bce0815f-1e92-4238-999a-828e3e0068f1"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("de190a1f-6879-412e-aaf9-f0709d0bb6a0"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("5bb4232e-9d9b-4274-a4b1-e5a03ea75656"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("2124ce5a-d76c-4ece-a92f-74bd232cf2bd"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("91f2954b-f8b1-435c-9f97-48e20856b803"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("ba52597d-c31a-4dfc-bb53-8672217fad95"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("9e34e26e-bcfe-483b-9aad-86907f328243"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("556757c6-59f2-45a9-bedd-9c5285353119"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("d8abf33c-9fa3-484f-a0ae-632403a5f703"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("d0599723-5032-445c-a2df-0ecacf9ee6c8"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("f6021c8b-5c5a-4868-a46b-51d80937f9af"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 },
                    { new Guid("d667d1d4-3766-4ea6-942d-d7fc30ffd9ca"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("4308a1aa-b4df-40b7-b87a-f492f6edffb7"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("f4243427-a940-434a-98a5-2072607ff760"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("859743fc-ac68-4341-a502-9f41943c3c11"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsProductId",
                table: "OrderProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerPersonId",
                table: "Orders",
                column: "CustomerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitId",
                table: "Products",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

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
