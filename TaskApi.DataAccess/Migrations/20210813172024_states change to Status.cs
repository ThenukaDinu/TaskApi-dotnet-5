using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class stateschangetoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "States",
                table: "Todos",
                newName: "Status");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Todos",
                newName: "States");

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
    }
}
