using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anchorage.Server.Migrations
{
    public partial class Unkoniki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BoardKey = table.Column<string>(nullable: false),
                    BoardName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ThreadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    ThreadId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    BoardKey = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ResponseCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.ThreadId);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "BoardKey", "BoardName" },
                values: new object[,]
                {
                    { 1, "news7vip", "裏VIP" },
                    { 2, "coffeehouse", "雑談ルノワール" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Author", "Body", "Created", "Mail", "Name", "ThreadId" },
                values: new object[,]
                {
                    { 1, "oienriboe", "うんちぶりぶりのすばらしさはいじょうなものであるということ", new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), null, null, 1 },
                    { 2, "gerg", "やはりなというかんじである", new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), null, null, 1 },
                    { 3, "fweg", "それはいえどもわれわれのかんじるところではないな", new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), null, null, 2 },
                    { 4, "oienriboe", "ではやはりそうとであるか", new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), null, null, 2 },
                    { 5, "gerg", "なあなあでおわらせてはいけない", new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Author", "BoardKey", "Created", "Modified", "ResponseCount", "Title" },
                values: new object[,]
                {
                    { 1, "oienriboe", "news7vip", new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), 2, "ええな" },
                    { 2, "fweg", "news7vip", new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), 2, "ええぞ" },
                    { 3, "gerg", "coffeehouse", new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), 1, "いいぞ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Threads");
        }
    }
}
