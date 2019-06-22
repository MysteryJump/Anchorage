using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class fwfgwgwed43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 24, 793, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 24, 793, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 24, 793, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 24, 793, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 6, 18, 21, 29, 24, 793, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local), new DateTime(2019, 6, 18, 21, 29, 24, 792, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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
    }
}
