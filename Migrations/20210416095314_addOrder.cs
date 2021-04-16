using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class addOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerPersonId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerPersonId",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "CustomerPersonId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderCustomers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustomers", x => new { x.OrderId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_OrderCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderCustomers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "Date", "ProductId" },
                values: new object[] { new Guid("7fa67b1d-9434-44aa-ab7c-c0815cc47963"), 21.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("e6423530-0f13-4bfe-97de-e7119950f93a"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("f0b0f3f9-bb94-4194-9a2b-cfb8dd8bee10"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("faa9937b-00a1-4582-a7de-8756c1bb1b83"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("af013445-ec70-444e-8cc6-c143a276aa42"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("e7677448-aefe-4450-a60a-9b718f8971f4"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("3d38a604-0321-4914-a7b0-02c5ffa8fa55"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("003b540d-bfa5-444f-baef-c22677cdf443"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("38c8733a-976e-469e-b3dd-064933872de4"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("e3506a8a-53da-43e2-adc2-6da626c1bd55"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("6d7e74b5-4968-4ad3-b38a-ec36c3063f7a"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("6368d486-2bef-4c52-9cef-c6f93734cc15"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("a913fc75-f592-4188-9cc4-03b156b02837"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("f2864db7-a3fd-4aa9-b4e3-4cf25fa50e64"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("49db23d0-addf-49ff-84ec-76f63d6e9de6"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("398997b6-a769-4b13-ab9b-4f7f93e85a64"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("f50c235c-537f-4ccb-a686-b01c2b794489"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_CustomerId",
                table: "OrderCustomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7fa67b1d-9434-44aa-ab7c-c0815cc47963"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("003b540d-bfa5-444f-baef-c22677cdf443"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38c8733a-976e-469e-b3dd-064933872de4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("398997b6-a769-4b13-ab9b-4f7f93e85a64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d38a604-0321-4914-a7b0-02c5ffa8fa55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("49db23d0-addf-49ff-84ec-76f63d6e9de6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6368d486-2bef-4c52-9cef-c6f93734cc15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d7e74b5-4968-4ad3-b38a-ec36c3063f7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a913fc75-f592-4188-9cc4-03b156b02837"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af013445-ec70-444e-8cc6-c143a276aa42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3506a8a-53da-43e2-adc2-6da626c1bd55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6423530-0f13-4bfe-97de-e7119950f93a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e7677448-aefe-4450-a60a-9b718f8971f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f0b0f3f9-bb94-4194-9a2b-cfb8dd8bee10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2864db7-a3fd-4aa9-b4e3-4cf25fa50e64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f50c235c-537f-4ccb-a686-b01c2b794489"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("faa9937b-00a1-4582-a7de-8756c1bb1b83"));

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CustomerPersonId",
                table: "Orders",
                type: "int",
                nullable: true);

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
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Thickness", "UnitId", "Width" },
                values: new object[,]
                {
                    { new Guid("aa809de1-9396-4517-8c76-24d09909437a"), "Oregon 7x15", 5.0099999999999998, 7.0, 1, 15.0 },
                    { new Guid("5b009212-0e6a-43c8-bcf3-7d221a878fda"), "Oregon 7x18", 4.6200000000000001, 7.0, 1, 18.0 },
                    { new Guid("502e264b-0add-4a90-a7b4-4b77bc88ae15"), "Pannelatten", 0.29999999999999999, 2.3999999999999999, 1, 3.2000000000000002 },
                    { new Guid("b318a3b6-aabc-4718-be0f-b1ba76526d26"), "Stoflatten", 0.22, 2.0, 1, 2.2999999999999998 },
                    { new Guid("2f438305-2580-4483-91e5-9aac0ee49cfc"), "RND gedrenkt", 0.84999999999999998, 2.5, 1, 10.0 },
                    { new Guid("8fd93d08-b5bd-4ff6-8f4b-0c6e189b7773"), "RND ongeschaafd", 0.60999999999999999, 2.0, 1, 10.0 },
                    { new Guid("42886646-8c13-4eae-99e3-6d768d67af06"), "Merantiplaten", 4.4500000000000002, 0.35999999999999999, 1, 122.0 },
                    { new Guid("90b0cd32-d72f-4dce-81cc-6d73d440c41e"), "CDX platen", 6.5599999999999996, 1.8, 2, 122.0 },
                    { new Guid("51eb08ce-ec71-4358-a15d-2f0e159e296b"), "OBS platen", 3.9700000000000002, 1.2, 2, 59.0 },
                    { new Guid("34f5dc41-5d20-4f69-a60e-98de3d8676c0"), "Meubelplaten wit", 5.6200000000000001, 1.0, 3, 20.0 },
                    { new Guid("fb7a4659-130e-44c8-b5ad-4c6a140e2f39"), "Gipsplaten", 2.6400000000000001, 0.90000000000000002, 2, 0.0 },
                    { new Guid("e8194bc9-a07e-4cc8-9ab1-f7c74548db23"), "Plafondlatten", 0.56999999999999995, 2.2000000000000002, 1, 4.5 },
                    { new Guid("f6e93395-9f70-46d1-8851-705898914ec3"), "CLS", 0.98999999999999999, 3.7999999999999998, 1, 5.7999999999999998 },
                    { new Guid("f3398a43-8420-4a21-92d2-666d25ae14ae"), "Terrasplanken tali", 6.3499999999999996, 2.5, 1, 14.5 },
                    { new Guid("9168538c-41ef-4207-a0a3-3eccb8d3dc3f"), "Thermowood", 6.1500000000000004, 63.0, 1, 150.0 },
                    { new Guid("91ad49d8-072d-48d4-9f59-512879e70931"), "Tali kepers", 2.8100000000000001, 40.0, 1, 55.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerPersonId",
                table: "Orders",
                column: "CustomerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsProductId",
                table: "OrderProduct",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerPersonId",
                table: "Orders",
                column: "CustomerPersonId",
                principalTable: "Customers",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
