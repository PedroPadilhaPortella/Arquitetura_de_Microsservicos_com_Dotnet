﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class SeedCouponsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "code", "discount_amount" },
                values: new object[] { 1L, "ERUDIO_2022_10", 10m });

            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "code", "discount_amount" },
                values: new object[] { 2L, "ERUDIO_2022_15", 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
