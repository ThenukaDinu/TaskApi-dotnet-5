using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Thenuka Jayarathna" },
                    { 2, "Pubudu Gamage" },
                    { 3, "Nishadi Hansika" },
                    { 4, "Nipun Gallage" },
                    { 5, "Isuru Anjana" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due", "Title" },
                values: new object[] { 1, new DateTime(2021, 8, 8, 23, 54, 2, 994, DateTimeKind.Local).AddTicks(4114), new DateTime(2021, 8, 13, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(2209), "Get books for school" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "States", "Title" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3138), "Clean the room", new DateTime(2021, 8, 13, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3139), 0, "Clean room" },
                    { 3, 3, new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3135), "Practice programming", new DateTime(2021, 8, 10, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3136), 0, "Do some programming practice" },
                    { 5, 4, new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3140), "Finish daily workout", new DateTime(2021, 8, 9, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3141), 0, "Workout for 30 minutes" },
                    { 2, 5, new DateTime(2021, 8, 8, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3122), "Get some food for next week", new DateTime(2021, 8, 11, 23, 54, 2, 995, DateTimeKind.Local).AddTicks(3127), 0, "Shopping for next week" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due", "Title" },
                values: new object[] { new DateTime(2021, 8, 8, 1, 29, 38, 970, DateTimeKind.Local).AddTicks(1580), new DateTime(2021, 8, 13, 1, 29, 38, 970, DateTimeKind.Local).AddTicks(9983), "Get books for school - DB" });
        }
    }
}
