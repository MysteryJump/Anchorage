using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Anchorage.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anchorage.Server.Controllers
{
    [Route("/{boardKey}/dat/{datKey}.dat")]
    [Controller]
    public class LegacyThreadsController : ControllerBase
    {
        private readonly MainContext _context;

        public LegacyThreadsController(MainContext context)
        {
            _context = context;
        }

        [Route("")]
        [Produces("text/plain; charset=shift_jis")]
        public async Task<string> Index([FromRoute] string boardKey, [FromRoute]string datKey)
        {
            if (!Startup.IsUsingLegacyMode)
            {
                return "";
            }
            var data = await _context.Threads.Where(x => x.BoardKey == boardKey && x.DatKey == long.Parse(datKey)).FirstOrDefaultAsync();
                
            if (data == null)
            {
                return "";
            }
            bool isfirst = true;

            var sb = new StringBuilder();
            var responses = await _context.Responses.Where(x => x.ThreadId == data.ThreadId).OrderBy(x => x.Created).ToListAsync();
            foreach (var item in responses)
            {
                if (isfirst)
                {
                    sb.AppendLine($"{item.Name}<>{item.Mail}<>{item.Created} ID:{item.Author}<> {item.Body} <> {data.Title}");
                    isfirst = false;
                }
                else
                {
                    sb.AppendLine($"{item.Name}<>{item.Mail}<>{item.Created} ID:{item.Author}<> {item.Body} <>");
                }
            }

            var utf = Encoding.Default;
            var shiftJis = Encoding.GetEncoding("Shift_JIS");

            var ubytes = utf.GetBytes(sb.ToString());
            var bytests = Encoding.Convert(utf, shiftJis, ubytes);
            return shiftJis.GetString(bytests);
        }
    }
}