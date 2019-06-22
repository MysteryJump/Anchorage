using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class safa333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSessions",
                columns: table => new
                {
                    SessionToken = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Expired = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSessions");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 39, 685, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 39, 686, DateTimeKind.Local) });
        }
    }
}
