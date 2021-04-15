using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thickness = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.UnitId);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "Width" },
                values: new object[,]
                {
                    { new Guid("efac1814-c014-4a61-beac-70914fee2447"), "Oregon 7x15", 5.0099999999999998, 7.0, 15.0 },
                    { new Guid("ca52d51f-3f20-436a-bc94-952ab27fb133"), "Tali kepers", 2.8100000000000001, 40.0, 55.0 },
                    { new Guid("242295fc-67e1-4879-9988-9c2c5124f151"), "Thermowood", 6.1500000000000004, 63.0, 150.0 },
                    { new Guid("c0beab4e-5cfa-457e-9592-9841ac584fbe"), "Terrasplanken tali", 6.3499999999999996, 2.5, 14.5 },
                    { new Guid("cf4e75d9-8680-4426-b7fb-b021c14c3d07"), "CLS", 0.98999999999999999, 3.7999999999999998, 5.7999999999999998 },
                    { new Guid("4ba85fce-ba82-4e82-a78a-6d7f60fb94ec"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 4.5 },
                    { new Guid("c6ab1756-b8fc-4c97-bdaa-9d101c03c0d8"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 0.0 },
                    { new Guid("11cb3725-712d-427b-95bd-4a3d6d39d620"), "OBS platen", 3.9700000000000002, 1.2, 59.0 },
                    { new Guid("3fe0990f-da7c-4eaa-ad74-767bb53c4dce"), "Meubelplaten wit", 5.6200000000000001, 1.0, 20.0 },
                    { new Guid("1b01d0a1-d4b1-48e9-bfb8-290e1ce21865"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 122.0 },
                    { new Guid("cbb9efdb-7266-4399-8143-509a08baa442"), "RND ongeschaafd", 0.60999999999999999, 2.0, 10.0 },
                    { new Guid("2c1894c0-5716-4bcb-9728-f6b4f905b162"), "RND gedrenkt", 0.84999999999999998, 2.5, 10.0 },
                    { new Guid("a1b155dd-58af-4a4f-b39a-8c0a6cc4d7f0"), "Stoflatten", 0.22, 2.0, 2.2999999999999998 },
                    { new Guid("0ed3a879-9779-49c0-8e60-ce7c69bfdb57"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 3.2000000000000002 },
                    { new Guid("5ed018fe-3c32-4575-b840-2e3eaa4cfee9"), "Oregon 7x18", 4.6200000000000001, 7.0, 18.0 },
                    { new Guid("30d2a068-4911-4778-9b8b-73b42b03b948"), "CDX platen", 6.5599999999999996, 1.8, 122.0 }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "UnitId", "Desc", "Name" },
                values: new object[,]
                {
                    { new Guid("01d4f0bf-50bd-448a-808a-1d3ddb1e63b3"), "Kubieke meter", "m³" },
                    { new Guid("c208378d-b3d4-47dd-8509-51a13232f494"), "Lopende meter", "lm" },
                    { new Guid("c0377bf7-27a7-402f-a41b-5f38e22e1c04"), "Vierkante meter", "m²" },
                    { new Guid("d077172a-a255-48ab-b08a-ea7bdd3a14c8"), "Stuk", "st" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Unit");
        }
    }
}
