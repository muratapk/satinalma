using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace satinalma.Migrations
{
    public partial class paket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password_hash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shipping_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    billing_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shipping_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    billing_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stock_quantity = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: true),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payment_method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ordersorder_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_Ordersorder_id",
                        column: x => x.Ordersorder_id,
                        principalTable: "Orders",
                        principalColumn: "order_id");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    added_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customerscustomer_id = table.Column<int>(type: "int", nullable: true),
                    Productsproduct_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_id);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_Customerscustomer_id",
                        column: x => x.Customerscustomer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id");
                    table.ForeignKey(
                        name: "FK_Carts_Products_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Products",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    order_detail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ordersorder_id = table.Column<int>(type: "int", nullable: true),
                    product_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.order_detail_id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Ordersorder_id",
                        column: x => x.Ordersorder_id,
                        principalTable: "Orders",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_product_id1",
                        column: x => x.product_id1,
                        principalTable: "Products",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateTable(
                name: "product_Reviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    review_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    product_id1 = table.Column<int>(type: "int", nullable: true),
                    Customerscustomer_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_product_Reviews_Customers_Customerscustomer_id",
                        column: x => x.Customerscustomer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id");
                    table.ForeignKey(
                        name: "FK_product_Reviews_Products_product_id1",
                        column: x => x.product_id1,
                        principalTable: "Products",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Customerscustomer_id",
                table: "Carts",
                column: "Customerscustomer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Productsproduct_id",
                table: "Carts",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Ordersorder_id",
                table: "OrderDetails",
                column: "Ordersorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_product_id1",
                table: "OrderDetails",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Ordersorder_id",
                table: "Payments",
                column: "Ordersorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_Reviews_Customerscustomer_id",
                table: "product_Reviews",
                column: "Customerscustomer_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_Reviews_product_id1",
                table: "product_Reviews",
                column: "product_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "product_Reviews");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
