using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class addStaffmember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1389cbe6-7513-44ab-a921-164013941ef6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("14163d6b-4827-495e-b054-881063193672"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("259a2939-8309-4a83-a882-259ec81f0f6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39aa422a-e060-4164-9c88-5d6d8d03db8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3cf83168-f907-4ed3-8f2c-07c766151b08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("41453897-4b21-4f85-9ecc-868f759df221"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5365b52e-5100-4959-916c-b35c22fae462"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("61dd4f13-bfdf-4ac4-bb60-39c062cc503b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad7a5fe6-5631-4f40-8c3a-0ebe6d9c1cde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b7b8b431-7952-49b7-9f0e-40a7a91c2560"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("daf92ab6-a022-458c-acaf-10b732d86f52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e272383a-3b48-46bb-8638-76f233796680"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e687657c-81c9-4be9-b770-056395aaa8d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ea74f6bd-83a5-43fb-bbe2-54eb646c6a2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3017254-7bf8-4b08-b1df-35c3156fc0d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f645eef5-2fbf-4e94-ab54-5dff266cabfe"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[] { 2, "Sander", "Coussement" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("f3398a43-8420-4a21-92d2-666d25ae14ae"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("f6e93395-9f70-46d1-8851-705898914ec3"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("e8194bc9-a07e-4cc8-9ab1-f7c74548db23"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("fb7a4659-130e-44c8-b5ad-4c6a140e2f39"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("34f5dc41-5d20-4f69-a60e-98de3d8676c0"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("51eb08ce-ec71-4358-a15d-2f0e159e296b"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("9168538c-41ef-4207-a0a3-3eccb8d3dc3f"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("90b0cd32-d72f-4dce-81cc-6d73d440c41e"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("8fd93d08-b5bd-4ff6-8f4b-0c6e189b7773"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("2f438305-2580-4483-91e5-9aac0ee49cfc"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("b318a3b6-aabc-4718-be0f-b1ba76526d26"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("502e264b-0add-4a90-a7b4-4b77bc88ae15"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("5b009212-0e6a-43c8-bcf3-7d221a878fda"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("aa809de1-9396-4517-8c76-24d09909437a"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("42886646-8c13-4eae-99e3-6d768d67af06"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("91ad49d8-072d-48d4-9f59-512879e70931"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "PersonId", "Email", "IsAdmin", "TelephoneNumber" },
                values: new object[] { 2, null, true, "0412345678" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2f438305-2580-4483-91e5-9aac0ee49cfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("34f5dc41-5d20-4f69-a60e-98de3d8676c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("42886646-8c13-4eae-99e3-6d768d67af06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("502e264b-0add-4a90-a7b4-4b77bc88ae15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("51eb08ce-ec71-4358-a15d-2f0e159e296b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5b009212-0e6a-43c8-bcf3-7d221a878fda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8fd93d08-b5bd-4ff6-8f4b-0c6e189b7773"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("90b0cd32-d72f-4dce-81cc-6d73d440c41e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9168538c-41ef-4207-a0a3-3eccb8d3dc3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91ad49d8-072d-48d4-9f59-512879e70931"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa809de1-9396-4517-8c76-24d09909437a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b318a3b6-aabc-4718-be0f-b1ba76526d26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8194bc9-a07e-4cc8-9ab1-f7c74548db23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3398a43-8420-4a21-92d2-666d25ae14ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f6e93395-9f70-46d1-8851-705898914ec3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fb7a4659-130e-44c8-b5ad-4c6a140e2f39"));

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("259a2939-8309-4a83-a882-259ec81f0f6e"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("e687657c-81c9-4be9-b770-056395aaa8d9"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("daf92ab6-a022-458c-acaf-10b732d86f52"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("5365b52e-5100-4959-916c-b35c22fae462"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("14163d6b-4827-495e-b054-881063193672"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("f3017254-7bf8-4b08-b1df-35c3156fc0d4"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("41453897-4b21-4f85-9ecc-868f759df221"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("39aa422a-e060-4164-9c88-5d6d8d03db8c"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("3cf83168-f907-4ed3-8f2c-07c766151b08"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("b7b8b431-7952-49b7-9f0e-40a7a91c2560"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("61dd4f13-bfdf-4ac4-bb60-39c062cc503b"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("ea74f6bd-83a5-43fb-bbe2-54eb646c6a2c"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("e272383a-3b48-46bb-8638-76f233796680"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("f645eef5-2fbf-4e94-ab54-5dff266cabfe"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("1389cbe6-7513-44ab-a921-164013941ef6"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("ad7a5fe6-5631-4f40-8c3a-0ebe6d9c1cde"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });
        }
    }
}
