using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class fwfgwgwed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 25, 24, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 25, 24, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 25, 24, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 25, 24, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 25, 24, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 25, 24, 437, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 25, 24, 438, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 25, 24, 438, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 25, 24, 438, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 25, 24, 438, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 25, 24, 438, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 773, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 24, 22, 49, 11, 775, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0)) });
        }
    }
}
