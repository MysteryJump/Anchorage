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
        [Produces("text/plain; charset=shift_jis")]
        [HttpPost()]
        public async Task<string> Index([FromBody]string body)
        {
            var bbs = new BbsCgiRequest(body);
            throw new NotImplementedException();
        }

        private class BbsCgiRequest
        {
            public string Body { get; set; }
            public string BoardKey { get; set; }
            public string DatKey { get; set; }
            public string Name { get; set; }
            public string Mail { get; set; }
            public string Title { get; set; }

            public BbsCgiRequest(string rawText)
            {
                var regex = new Regex(@"bbs=(?<bbs>.+)&key;=(?<dat>\d{9,10})&time;=(.*)&FROM;=(?<name>.*)&mail;=(?<mail>.*)&MESSAGE;=(?<body>.+)&submit;=.*");
                var match = regex.Match(rawText);
                if (match.Success)
                {
                    Body = match.Groups["body"].Value;
                    BoardKey = match.Groups["bbs"].Value;
                    DatKey = match.Groups["dat"].Value;
                    Mail = match.Groups["mail"].Value;
                    Name = match.Groups["name"].Value;
                 
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            public Thread ToThread()
            {
                
                var th = new Thread()
                {
                    BoardKey = BoardKey,
                    
                };
                th.Initialize(IpManager.GetHostName());
                throw new NotImplementedException();
            }
        }
    }

}