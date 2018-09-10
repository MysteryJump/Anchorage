using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class unkotiburiburi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HostAddress",
                table: "Responses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "HostAddress" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), "127.0.0.1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "HostAddress" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), "127.0.0.1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "HostAddress" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), "192.168.0.0.1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "HostAddress" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), "127.0.0.1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "HostAddress" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), "114.51.41.91" });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 178, DateTimeKind.Local), new DateTime(2018, 9, 10, 2, 16, 48, 179, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local), new DateTime(2018, 9, 10, 2, 16, 48, 180, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HostAddress",
                table: "Responses");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 39, 56, 971, DateTimeKind.Local), new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local), new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local), new DateTime(2018, 9, 9, 1, 39, 56, 972, DateTimeKind.Local) });
        }
    }
}
