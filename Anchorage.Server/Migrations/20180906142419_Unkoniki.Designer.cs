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
    [Migration("20180906142419_Unkoniki")]
    partial class Unkoniki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Anchorage.Shared.Models.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoardKey")
                        .IsRequired();

                    b.Property<string>("BoardName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Boards");

                    b.HasData(
                        new { Id = 1, BoardKey = "news7vip", BoardName = "裏VIP" },
                        new { Id = 2, BoardKey = "coffeehouse", BoardName = "雑談ルノワール" }
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

                    b.Property<string>("Mail");

                    b.Property<string>("Name");

                    b.Property<int>("ThreadId");

                    b.HasKey("Id");

                    b.ToTable("Responses");

                    b.HasData(
                        new { Id = 1, Author = "oienriboe", Body = "うんちぶりぶりのすばらしさはいじょうなものであるということ", Created = new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), ThreadId = 1 },
                        new { Id = 2, Author = "gerg", Body = "やはりなというかんじである", Created = new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), ThreadId = 1 },
                        new { Id = 3, Author = "fweg", Body = "それはいえどもわれわれのかんじるところではないな", Created = new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), ThreadId = 2 },
                        new { Id = 4, Author = "oienriboe", Body = "ではやはりそうとであるか", Created = new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), ThreadId = 2 },
                        new { Id = 5, Author = "gerg", Body = "なあなあでおわらせてはいけない", Created = new DateTime(2018, 9, 6, 23, 24, 19, 587, DateTimeKind.Local), ThreadId = 3 }
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

                    b.Property<DateTime>("Modified");

                    b.Property<int>("ResponseCount");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ThreadId");

                    b.ToTable("Threads");

                    b.HasData(
                        new { ThreadId = 1, Author = "oienriboe", BoardKey = "news7vip", Created = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), Modified = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), ResponseCount = 2, Title = "ええな" },
                        new { ThreadId = 2, Author = "fweg", BoardKey = "news7vip", Created = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), Modified = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), ResponseCount = 2, Title = "ええぞ" },
                        new { ThreadId = 3, Author = "gerg", BoardKey = "coffeehouse", Created = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), Modified = new DateTime(2018, 9, 6, 23, 24, 19, 586, DateTimeKind.Local), ResponseCount = 1, Title = "いいぞ" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
