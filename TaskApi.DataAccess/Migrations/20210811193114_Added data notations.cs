using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class Addeddatanotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "Colombo 1", "street 1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "22", "Colombo 5", "street 2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "14", "Kandy", "street 4" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "55", "Nugegoda", "street 5" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "422/1", "Galle", "street 6" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 12, 1, 1, 13, 803, DateTimeKind.Local).AddTicks(8261), new DateTime(2021, 8, 17, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 12, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8722), new DateTime(2021, 8, 15, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 12, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8741), new DateTime(2021, 8, 14, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 12, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8744), new DateTime(2021, 8, 17, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 12, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 8, 13, 1, 1, 13, 804, DateTimeKind.Local).AddTicks(8748) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 54, 2, 994, DateTimeKind.Local).AddTicks(4114), new DateTime(2021, 8, 13, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3122), new DateTime(2021, 8, 11, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3135), new DateTime(2021, 8, 10, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 8, 13, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3140), new DateTime(2021, 8, 9, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3141) });
        }
    }
}
