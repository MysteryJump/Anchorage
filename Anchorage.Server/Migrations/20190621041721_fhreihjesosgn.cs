using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class fhreihjesosgn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Authority",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 21, 13, 17, 21, 535, DateTimeKind.Local), new DateTime(2019, 6, 21, 13, 17, 21, 535, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Authority",
                table: "Users");

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
    }
}
