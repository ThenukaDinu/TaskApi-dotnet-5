using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class jobrolefieldaddedtoauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Systems Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 39, 25, 16, DateTimeKind.Local).AddTicks(6069), new DateTime(2021, 8, 18, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5395), new DateTime(2021, 8, 16, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5407), new DateTime(2021, 8, 15, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5410), new DateTime(2021, 8, 18, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5413), new DateTime(2021, 8, 14, 23, 39, 25, 17, DateTimeKind.Local).AddTicks(5414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 22, 50, 24, 485, DateTimeKind.Local).AddTicks(8585), new DateTime(2021, 8, 18, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8382), new DateTime(2021, 8, 16, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8394), new DateTime(2021, 8, 15, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8398), new DateTime(2021, 8, 18, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 13, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8400), new DateTime(2021, 8, 14, 22, 50, 24, 486, DateTimeKind.Local).AddTicks(8401) });
        }
    }
}
