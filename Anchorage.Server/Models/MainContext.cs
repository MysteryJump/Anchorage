using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anchorage.Shared.Models;
using Newtonsoft.Json;

namespace Anchorage.Server.Models
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)  : base(options) { }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasIndex(x => x.UserId).IsUnique(true);

            modelBuilder.Entity<Board>().HasData(new[]
            {
                new Board(){ BoardKey = "news7vip", BoardName = "裏VIP" , Id = 1,BoardDefaultName="以下、名無しにかわりまして裏VIP(´・ω・`)がお送りします" },
                new Board(){ BoardKey = "coffeehouse", BoardName="雑談ルノワール", Id = 2,BoardDefaultName="雑談うんちー" }
            });
            //modelBuilder.Entity<Thread>().HasData(new[]
            //{
            //    new Thread(){BoardKey = "news7vip", Author = "oienriboe", ThreadId = 1, Created = DateTime.Now, Modified = DateTime.Now, Title = "ええな",ResponseCount = 2 },
            //    new Thread(){BoardKey = "news7vip", Author = "fweg", ThreadId = 2, Created = DateTime.Now, Modified = DateTime.Now, Title = "ええぞ",ResponseCount = 2 },
            //    new Thread(){BoardKey = "coffeehouse", Author = "gerg", ThreadId = 3, Created = DateTime.Now, Modified = DateTime.Now, Title = "いいぞ", ResponseCount = 1 }
            //});
            //modelBuilder.Entity<Response>().HasData(new[]
            //{
            //    new Response(){ Author="oienriboe", Body = "うんちぶりぶりのすばらしさはいじょうなものであるということ", Created = DateTime.Now, Id = 1, ThreadId = 1, HostAddress = "127.0.0.1"},
            //    new Response(){ Author="gerg", Body = "やはりなというかんじである", Created = DateTime.Now, Id = 2, ThreadId = 1, HostAddress = "127.0.0.1" },
            //    new Response(){ Author="fweg", Body = "それはいえどもわれわれのかんじるところではないな", Created = DateTime.Now, Id = 3, ThreadId = 2 ,HostAddress="192.168.0.0.1"},
            //    new Response(){ Author="oienriboe", Body = "ではやはりそうとであるか", Created = DateTime.Now, Id = 4, ThreadId = 2, HostAddress="127.0.0.1"},
            //    new Response(){ Author="gerg", Body = "なあなあでおわらせてはいけない", Created = DateTime.Now, Id = 5, ThreadId = 3, HostAddress="114.51.41.91"}
            //});
        }
    }
}
