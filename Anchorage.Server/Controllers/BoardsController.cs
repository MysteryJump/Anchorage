using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Anchorage.Server.Models;
using Anchorage.Shared.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;

namespace Anchorage.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly MainContext _context;

        public BoardsController(MainContext context)
        {
            _context = context;
        }

        // GET: api/Boards
        [HttpGet]
        public IEnumerable<Board> GetBoards()
        {
            
            return _context.Boards;
        }

        // GET: api/Boards/news7vip
        [HttpGet("{boardKey}")]
        public async Task<IActionResult> GetBoard([FromRoute] string boardKey)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var board = await _context.Boards.FirstOrDefaultAsync(x => x.BoardKey == boardKey);

            if (board == null)
            {
                return NotFound();
            }
            board.Child = await _context.Threads.Where(x => x.BoardKey == boardKey).OrderByDescending(x => x.Modified).ToListAsync();
            return Ok(board);
        }
        // GET: api/Boards/news7vip/1 (child id)
        [HttpGet("{boardKey}/{threadId}")]
        public async Task<IActionResult> GetThread([FromRoute]string boardKey, [FromRoute] int threadId)
        {
            var thread = await _context.Threads.FindAsync(threadId);
            if (thread == null || thread.BoardKey != boardKey)
            {
                return NotFound();
            }

            thread.Responses = await _context.Responses.Where(x => x.ThreadId == threadId).ToListAsync();
            return Ok(thread);
        }

        // POST: api/Boards/news7vip
        [HttpPost("{boardKey}")]
        public async Task<IActionResult> CreateThread([FromRoute] string boardKey,[FromBody]ClientThread thread)
        {

            var body = new Thread
            {
                BoardKey = boardKey,
                Title = thread.Title
            };
            var response = new Response() {  Body = thread.Response.Body, Mail = thread.Response.Mail , Name = thread.Response.Name };
            
            if (response == null)
            {
                return BadRequest();
            }
            var ip = GetHostName();
            body.Initialize(ip);
            
            var result =  _context.Threads.Add(body);
            await _context.SaveChangesAsync();
            response.Initialize(result.Entity.ThreadId,ip,boardKey);
            _context.Responses.Add(response);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetThread), new { id = result.Entity.ThreadId } , result.Entity);
        }

        // POST: api/Boards/news7vip/1
        [HttpPost("{boardKey}/{threadId}")]
        public async Task<IActionResult> CreateResponse([FromRoute] string boardKey, [FromRoute] int threadId, [FromBody]ClientResponse body)
        {
            var thread = await _context.Threads.FirstOrDefaultAsync(x => (x.ThreadId == threadId && x.BoardKey == boardKey));
            if (thread == null)
            {
                return BadRequest();
            }
            var response = new Response() { Name = body.Name, Mail = body.Mail, Body = body.Body };
            response.Initialize(threadId,GetHostName(),boardKey);
            _context.Responses.Add(response);
            thread.ResponseCount += 1;
            thread.Modified = response.Created;
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetThread), new { id = threadId }, response);
        }

        #region Unused region

        // PUT: api/Boards/5
        [HttpPut("{id}")]
        public IActionResult PutBoard([FromRoute] int id, [FromBody] Board board)
        {
            return BadRequest();
        }

        // POST: api/Boards
        [HttpPost]
        public async Task<IActionResult> PostBoard([FromBody] Board board, [FromHeader] string xxx)
        {
            if (xxx != "ENTRY")
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Boards.Add(board);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoard", new { id = board.Id }, board);
        }

        // DELETE: api/Boards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard([FromRoute] int id,[FromHeader] string xxx)
        {
            if (xxx != "ENTRY")
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var board = await _context.Boards.FindAsync(id);
            if (board == null)
            {
                return NotFound();
            }

            _context.Boards.Remove(board);
            await _context.SaveChangesAsync();

            return Ok(board);
        }
        #endregion

        private bool BoardExists(string boardKey)
        {
            return _context.Boards.Any(e => e.BoardKey == boardKey);
        }

        private string GetHostName()
        {
            try
            {
                var ip = Dns.GetHostEntry(Dns.GetHostName());
                return ip.AddressList[0].ToString();
            }
            catch (SocketException)
            {

                return null;
            }
        }
    }
}