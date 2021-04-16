using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class addCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2124ce5a-d76c-4ece-a92f-74bd232cf2bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3ba258d9-f88b-4fc8-a1b0-bcacb1793533"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4308a1aa-b4df-40b7-b87a-f492f6edffb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("556757c6-59f2-45a9-bedd-9c5285353119"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5bb4232e-9d9b-4274-a4b1-e5a03ea75656"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("859743fc-ac68-4341-a502-9f41943c3c11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91f2954b-f8b1-435c-9f97-48e20856b803"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e34e26e-bcfe-483b-9aad-86907f328243"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba52597d-c31a-4dfc-bb53-8672217fad95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce0815f-1e92-4238-999a-828e3e0068f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d0599723-5032-445c-a2df-0ecacf9ee6c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d667d1d4-3766-4ea6-942d-d7fc30ffd9ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8abf33c-9fa3-484f-a0ae-632403a5f703"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("de190a1f-6879-412e-aaf9-f0709d0bb6a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f4243427-a940-434a-98a5-2072607ff760"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f6021c8b-5c5a-4868-a46b-51d80937f9af"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[] { 1, "Jonas", "De Meyer" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("f645eef5-2fbf-4e94-ab54-5dff266cabfe"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("e272383a-3b48-46bb-8638-76f233796680"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("ea74f6bd-83a5-43fb-bbe2-54eb646c6a2c"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("61dd4f13-bfdf-4ac4-bb60-39c062cc503b"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("b7b8b431-7952-49b7-9f0e-40a7a91c2560"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("3cf83168-f907-4ed3-8f2c-07c766151b08"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("1389cbe6-7513-44ab-a921-164013941ef6"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("39aa422a-e060-4164-9c88-5d6d8d03db8c"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("f3017254-7bf8-4b08-b1df-35c3156fc0d4"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("14163d6b-4827-495e-b054-881063193672"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("5365b52e-5100-4959-916c-b35c22fae462"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("daf92ab6-a022-458c-acaf-10b732d86f52"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("e687657c-81c9-4be9-b770-056395aaa8d9"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("259a2939-8309-4a83-a882-259ec81f0f6e"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("41453897-4b21-4f85-9ecc-868f759df221"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("ad7a5fe6-5631-4f40-8c3a-0ebe6d9c1cde"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "PersonId", "CompanyNumber" },
                values: new object[] { 1, "0123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "PersonId",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

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
                    { new Guid("d667d1d4-3766-4ea6-942d-d7fc30ffd9ca"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("4308a1aa-b4df-40b7-b87a-f492f6edffb7"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("859743fc-ac68-4341-a502-9f41943c3c11"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("f4243427-a940-434a-98a5-2072607ff760"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("9e34e26e-bcfe-483b-9aad-86907f328243"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("556757c6-59f2-45a9-bedd-9c5285353119"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("d8abf33c-9fa3-484f-a0ae-632403a5f703"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("d0599723-5032-445c-a2df-0ecacf9ee6c8"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("f6021c8b-5c5a-4868-a46b-51d80937f9af"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });
        }
    }
}
