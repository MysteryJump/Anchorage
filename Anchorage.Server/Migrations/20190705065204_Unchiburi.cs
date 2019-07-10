using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class Unchiburi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Author", "Body", "Created", "HostAddress", "Mail", "Name", "ThreadId" },
                values: new object[,]
                {
                    { 1, "oienriboe", "うんちぶりぶりのすばらしさはいじょうなものであるということ", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), "127.0.0.1", null, null, 1 },
                    { 2, "gerg", "やはりなというかんじである", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), "127.0.0.1", null, null, 1 },
                    { 3, "fweg", "それはいえどもわれわれのかんじるところではないな", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), "192.168.0.0.1", null, null, 2 },
                    { 4, "oienriboe", "ではやはりそうとであるか", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), "127.0.0.1", null, null, 2 },
                    { 5, "gerg", "なあなあでおわらせてはいけない", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), "114.51.41.91", null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Author", "BoardKey", "Created", "DatKey", "Modified", "ResponseCount", "Title" },
                values: new object[,]
                {
                    { 1, "oienriboe", "news7vip", new DateTime(2019, 6, 21, 13, 17, 21, 535, DateTimeKind.Local), 0L, new DateTime(2019, 6, 21, 13, 17, 21, 535, DateTimeKind.Local), 2, "ええな" },
                    { 2, "fweg", "news7vip", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), 0L, new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), 2, "ええぞ" },
                    { 3, "gerg", "coffeehouse", new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), 0L, new DateTime(2019, 6, 21, 13, 17, 21, 536, DateTimeKind.Local), 1, "いいぞ" }
                });
        }
    }
}
