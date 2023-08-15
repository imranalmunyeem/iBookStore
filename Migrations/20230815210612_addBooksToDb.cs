using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iBookStore.Migrations
{
    /// <inheritdoc />
    public partial class addBooksToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DatePublished", "Description", "ISBN", "ImageUrl", "Language", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Gayle Laakmann McDowell", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782869", "/images/coding.jpg", "English", 139, "Crack the coding Interview" },
                    { 2, "Imran Al Munyeem", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782862", "/images/python.jpg", "English", 139, "Python Coding" },
                    { 3, "Mahmoud Artemi", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782861", "/images/netcore.jpg", "English", 139, "MVC Dot net core" },
                    { 4, "Imran Al Munyeem", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782862", "/images/javascript.jpg", "English", 139, "Advance JavaScript" },
                    { 5, "Imran Al Munyeem", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782863", "/images/apitest.jpg", "English", 139, "API Testing" },
                    { 6, "Imran Al Munyeem", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782864", "/images/automation.jpg", "English", 139, "Automate Everything" },
                    { 7, "Mahmoud Artemi", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), " Test Description", "0984782865", "/images/pattern.jpg", "English", 139, "Design Pattern" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
