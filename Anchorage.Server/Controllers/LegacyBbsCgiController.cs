using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchorage.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Anchorage.Shared.Models;
using Anchorage.Server.Controllers.Common;
using System.Net;
using System.IO;
using System.Web;

namespace Anchorage.Server.Controllers
{
    [Route("/test/bbs.cgi")]
    [Controller]
    public class LegacyBbsCgiController : ControllerBase
    {
        private readonly MainContext _context;

        public LegacyBbsCgiController(MainContext context)
        {
            _context = context;
        }
        [Route("")]
        [Consumes("application/x-www-form-urlencoded")]
        [HttpPost()]
        public async Task<string> Index()
        {
            var forms = HttpContext.Request.Form;
            var body = HttpContext.Request.Body;
            var sr = new StreamReader(Request.Body);
            var str = sr.ReadToEnd();

            var req = new BbsCgiRequest(forms, _context, HttpContext.Connection);
            await req.ApplyRequest();
            return null;
            
        }

        public class BbsCgiRequest
        {
            public string Body { get; set; }
            public string BoardKey { get; set; }
            public string DatKey { get; set; }
            public string Name { get; set; }
            public string Mail { get; set; }
            public string Title { get; set; }

            public bool IsThread { get; set; } = true;

            private MainContext _context;
            private ConnectionInfo _connectionInfo;
            public BbsCgiRequest(IFormCollection collections, MainContext context, ConnectionInfo connectionInfo)
            {
                Name = collections["FROM"];
                Mail = collections["mail"];
                var a = collections["MESSAGE"];
                var tst = Encoding.UTF8.GetString(Encoding.Convert(Encoding.GetEncoding("Shift_JIS"),
                    Encoding.UTF8, Encoding.GetEncoding("Shift_JIS").GetBytes(collections["MESSAGE"])));


                Body = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(collections["MESSAGE"]), Encoding.GetEncoding("Shift-JIS"));


                BoardKey = collections["bbs"];
                if (collections.ContainsKey("key"))
                {
                    DatKey = collections["key"];
                    IsThread = false;
                }
                else
                {
                    Title = collections["title"];
                }
                _context = context;
                _connectionInfo = connectionInfo;
            }

            public async Task ApplyRequest()
            {
                if (IsThread)
                {
                    await ApplyThreadRequest();
                }
                else
                {
                    await ApplyResponseRequest();
                }
            }

            private async Task ApplyThreadRequest()
            {
                var thread = new Thread();
                var ip = IpManager.GetHostName(_connectionInfo);
                thread.Initialize(ip);
                thread.BoardKey = BoardKey;
                thread.Title = Title;
                var response = new Response() { Body = Body, Mail = Mail, Name = Name };
                var result = _context.Threads.Add(thread);
                await _context.SaveChangesAsync();
                response.Initialize(result.Entity.ThreadId,ip,BoardKey);
                _context.Responses.Add(response);
                await _context.SaveChangesAsync();
            }
            private async Task ApplyResponseRequest()
            {
                var response = new Response();
                var targetThread = await _context.Threads.Where(x => x.DatKey == long.Parse(DatKey)).FirstOrDefaultAsync();
                response.Initialize(targetThread.ThreadId, IpManager.GetHostName(_connectionInfo), BoardKey);
                response.Body = Body;
                response.Name = Name;
                response.Mail = Mail;
                _context.Responses.Add(response);
                targetThread.ResponseCount++;
                targetThread.Modified = response.Created;
                await _context.SaveChangesAsync();
            }
        }
    }

}