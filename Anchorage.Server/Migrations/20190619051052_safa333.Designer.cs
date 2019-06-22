﻿// <auto-generated />
using System;
using Anchorage.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Anchorage.Server.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20190619051052_safa333")]
    partial class safa333
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Anchorage.Server.Models.UserSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Expired");

                    b.Property<string>("SessionToken");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("Anchorage.Shared.Models.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoardDefaultName")
                        .IsRequired();

                    b.Property<string>("BoardKey")
                        .IsRequired();

                    b.Property<string>("BoardName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Boards");

                    b.HasData(
                        new { Id = 1, BoardDefaultName = "以下、名無しにかわりまして裏VIP(´・ω・`)がお送りします", BoardKey = "news7vip", BoardName = "裏VIP" },
                        new { Id = 2, BoardDefaultName = "雑談うんちー", BoardKey = "coffeehouse", BoardName = "雑談ルノワール" }
                    );
                });

            modelBuilder.Entity("Anchorage.Shared.Models.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<string>("HostAddress")
                        .IsRequired();

                    b.Property<string>("Mail");

                    b.Property<string>("Name");

                    b.Property<int>("ThreadId");

                    b.HasKey("Id");

                    b.ToTable("Responses");

                    b.HasData(
                        new { Id = 1, Author = "oienriboe", Body = "うんちぶりぶりのすばらしさはいじょうなものであるということ", Created = new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local), HostAddress = "127.0.0.1", ThreadId = 1 },
                        new { Id = 2, Author = "gerg", Body = "やはりなというかんじである", Created = new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local), HostAddress = "127.0.0.1", ThreadId = 1 },
                        new { Id = 3, Author = "fweg", Body = "それはいえどもわれわれのかんじるところではないな", Created = new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local), HostAddress = "192.168.0.0.1", ThreadId = 2 },
                        new { Id = 4, Author = "oienriboe", Body = "ではやはりそうとであるか", Created = new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local), HostAddress = "127.0.0.1", ThreadId = 2 },
                        new { Id = 5, Author = "gerg", Body = "なあなあでおわらせてはいけない", Created = new DateTime(2019, 6, 19, 14, 10, 52, 88, DateTimeKind.Local), HostAddress = "114.51.41.91", ThreadId = 3 }
                    );
                });

            modelBuilder.Entity("Anchorage.Shared.Models.Thread", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("BoardKey")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<long>("DatKey");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("ResponseCount");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ThreadId");

                    b.ToTable("Threads");

                    b.HasData(
                        new { ThreadId = 1, Author = "oienriboe", BoardKey = "news7vip", Created = new DateTime(2019, 6, 19, 14, 10, 52, 86, DateTimeKind.Local), DatKey = 0L, Modified = new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), ResponseCount = 2, Title = "ええな" },
                        new { ThreadId = 2, Author = "fweg", BoardKey = "news7vip", Created = new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), DatKey = 0L, Modified = new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), ResponseCount = 2, Title = "ええぞ" },
                        new { ThreadId = 3, Author = "gerg", BoardKey = "coffeehouse", Created = new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), DatKey = 0L, Modified = new DateTime(2019, 6, 19, 14, 10, 52, 87, DateTimeKind.Local), ResponseCount = 1, Title = "いいぞ" }
                    );
                });

            modelBuilder.Entity("Anchorage.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
