using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "States", "Title" },
                values: new object[] { 1, new DateTime(2021, 8, 8, 1, 29, 38, 970, DateTimeKind.Local).AddTicks(1580), "Get some text books for school", new DateTime(2021, 8, 13, 1, 29, 38, 970, DateTimeKind.Local).AddTicks(9983), 0, "Get books for school - DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
