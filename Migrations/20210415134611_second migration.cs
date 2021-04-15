using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("0ed3a879-9779-49c0-8e60-ce7c69bfdb57"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("11cb3725-712d-427b-95bd-4a3d6d39d620"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1b01d0a1-d4b1-48e9-bfb8-290e1ce21865"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("242295fc-67e1-4879-9988-9c2c5124f151"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2c1894c0-5716-4bcb-9728-f6b4f905b162"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("30d2a068-4911-4778-9b8b-73b42b03b948"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("3fe0990f-da7c-4eaa-ad74-767bb53c4dce"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4ba85fce-ba82-4e82-a78a-6d7f60fb94ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5ed018fe-3c32-4575-b840-2e3eaa4cfee9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a1b155dd-58af-4a4f-b39a-8c0a6cc4d7f0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c0beab4e-5cfa-457e-9592-9841ac584fbe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c6ab1756-b8fc-4c97-bdaa-9d101c03c0d8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ca52d51f-3f20-436a-bc94-952ab27fb133"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("cbb9efdb-7266-4399-8143-509a08baa442"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("cf4e75d9-8680-4426-b7fb-b021c14c3d07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("efac1814-c014-4a61-beac-70914fee2447"));

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: new Guid("01d4f0bf-50bd-448a-808a-1d3ddb1e63b3"));

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: new Guid("c0377bf7-27a7-402f-a41b-5f38e22e1c04"));

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: new Guid("c208378d-b3d4-47dd-8509-51a13232f494"));

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: new Guid("d077172a-a255-48ab-b08a-ea7bdd3a14c8"));

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "Width" },
                values: new object[,]
                {
                    { new Guid("8b6f35a6-75bb-4b64-acf7-d8674019ad05"), "Oregon 7x15", 5.0099999999999998, 7.0, 15.0 },
                    { new Guid("31c75690-ce1d-4d58-82c1-c48e0b42c194"), "Tali kepers", 2.8100000000000001, 40.0, 55.0 },
                    { new Guid("8d941eaf-8acf-4a51-9218-ed89646b5306"), "Thermowood", 6.1500000000000004, 63.0, 150.0 },
                    { new Guid("83763a83-ebaf-486e-9137-04ebbcd230a3"), "Terrasplanken tali", 6.3499999999999996, 2.5, 14.5 },
                    { new Guid("d878e6e2-7ff9-45e6-b5b4-4f8556f288fe"), "CLS", 0.98999999999999999, 3.7999999999999998, 5.7999999999999998 },
                    { new Guid("320ff00c-78a4-4525-89fb-4f4ba7a0ad6b"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 4.5 },
                    { new Guid("becb5a2c-a47e-40c0-8b11-816e65b03cf9"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 0.0 },
                    { new Guid("abd63f4e-b3cc-45c3-a5ca-3fec43a9c048"), "OBS platen", 3.9700000000000002, 1.2, 59.0 },
                    { new Guid("183ffada-40d8-4368-88ce-9568db16d612"), "Meubelplaten wit", 5.6200000000000001, 1.0, 20.0 },
                    { new Guid("8e069572-6397-406e-a7bd-5145fed3d5c3"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 122.0 },
                    { new Guid("dc527628-8d7b-4fa2-811a-af7485fc5c40"), "RND ongeschaafd", 0.60999999999999999, 2.0, 10.0 },
                    { new Guid("ceabaf33-912f-43fd-bca0-4fbe7293be63"), "RND gedrenkt", 0.84999999999999998, 2.5, 10.0 },
                    { new Guid("d3300290-30cc-41ac-8519-665257d31cb5"), "Stoflatten", 0.22, 2.0, 2.2999999999999998 },
                    { new Guid("ffb573dc-7c71-44df-96dc-7b8cb17d1fa2"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 3.2000000000000002 },
                    { new Guid("abadf9f4-de1f-47a0-81bf-52edf0f8fa42"), "Oregon 7x18", 4.6200000000000001, 7.0, 18.0 },
                    { new Guid("63224a77-3d77-4694-a6a3-88d8c2f331ad"), "CDX platen", 6.5599999999999996, 1.8, 122.0 }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "UnitId", "Desc", "Name" },
                values: new object[,]
                {
                    { new Guid("00019668-e681-4f91-96b6-96840ae96dbc"), "Kubieke meter", "m³" },
                    { new Guid("490a11b4-d282-4e7b-b0fa-89ee96045751"), "Lopende meter", "lm" },
                    { new Guid("f82de43e-179e-4bc8-9d9e-1d3768e95665"), "Vierkante meter", "m²" },
                    { new Guid("4d80392b-1204-4191-95dd-c3b39f8bff0a"), "Stuk", "st" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("183ffada-40d8-4368-88ce-9568db16d612"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("31c75690-ce1d-4d58-82c1-c48e0b42c194"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("320ff00c-78a4-4525-89fb-4f4ba7a0ad6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("63224a77-3d77-4694-a6a3-88d8c2f331ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83763a83-ebaf-486e-9137-04ebbcd230a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b6f35a6-75bb-4b64-acf7-d8674019ad05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8d941eaf-8acf-4a51-9218-ed89646b5306"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e069572-6397-406e-a7bd-5145fed3d5c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("abadf9f4-de1f-47a0-81bf-52edf0f8fa42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("abd63f4e-b3cc-45c3-a5ca-3fec43a9c048"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("becb5a2c-a47e-40c0-8b11-816e65b03cf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ceabaf33-912f-43fd-bca0-4fbe7293be63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3300290-30cc-41ac-8519-665257d31cb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d878e6e2-7ff9-45e6-b5b4-4f8556f288fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dc527628-8d7b-4fa2-811a-af7485fc5c40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ffb573dc-7c71-44df-96dc-7b8cb17d1fa2"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitId",
                keyValue: new Guid("00019668-e681-4f91-96b6-96840ae96dbc"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitId",
                keyValue: new Guid("490a11b4-d282-4e7b-b0fa-89ee96045751"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitId",
                keyValue: new Guid("4d80392b-1204-4191-95dd-c3b39f8bff0a"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitId",
                keyValue: new Guid("f82de43e-179e-4bc8-9d9e-1d3768e95665"));

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

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
    }
}
