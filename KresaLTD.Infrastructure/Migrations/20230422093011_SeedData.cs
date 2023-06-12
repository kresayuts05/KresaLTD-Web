using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KresaLTD.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74796ebf-6d17-411a-8e53-93e95b459fb7", "de2cf037-9538-4da9-9181-6b7d8fdc4a37", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "beb93b68-264f-4784-a221-37a5ca33e0cc", 0, "Edelvais ", "Kazanlak", "46e01879-67d4-4013-8439-4f3bace47083", "Bulgaria", "yuliantsvetkov@gmail.com", false, "Yulian", true, "Tsvetkov", false, null, "YULIANTSVETKOV@GMAIL.COM", "YULIAN", "AQAAAAEAACcQAAAAEBPuLr8wnr0GaLS4j21qfnYOzVB0VwOlWkwJE3FInfFCkAgCAFPgr8XzyVYTzhI08w==", "0888278055", false, "e72c3256-d3b5-4984-aaa1-0b75f8a062e5", false, "yulian" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Кухни" },
                    { 2, "Бани" },
                    { 3, "Интериор" },
                    { 4, "Строителство" },
                    { 5, "Механизация" },
                    { 6, "Услуги с багер" },
                    { 7, "Услуги с вишка" },
                    { 8, "Транспортни услуги" },
                    { 9, "Изолации" },
                    { 10, "Покриви" },
                    { 11, "Сухо строителство" },
                    { 12, "Ремонти" },
                    { 13, "Реставрации" },
                    { 14, "ВиК" },
                    { 15, "Конструкции" },
                    { 16, "Други" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74796ebf-6d17-411a-8e53-93e95b459fb7", "beb93b68-264f-4784-a221-37a5ca33e0cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74796ebf-6d17-411a-8e53-93e95b459fb7", "beb93b68-264f-4784-a221-37a5ca33e0cc" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74796ebf-6d17-411a-8e53-93e95b459fb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "beb93b68-264f-4784-a221-37a5ca33e0cc");
        }
    }
}
