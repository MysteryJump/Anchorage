using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class unkoburiburi234321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 20, 13, 27, 4, 430, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 20, 13, 27, 4, 430, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 20, 13, 27, 4, 430, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 20, 13, 27, 4, 430, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 20, 13, 27, 4, 430, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 20, 13, 27, 4, 428, DateTimeKind.Local), new DateTime(2019, 6, 20, 13, 27, 4, 429, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 20, 13, 27, 4, 429, DateTimeKind.Local), new DateTime(2019, 6, 20, 13, 27, 4, 429, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 20, 13, 27, 4, 429, DateTimeKind.Local), new DateTime(2019, 6, 20, 13, 27, 4, 429, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 19, 14, 10, 52, 86, DateTimeKind.Local), new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local) });
        }
    }
}
