using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anchorage.Server.Models;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
        public IActionResult Index([FromRoute] string boardKey, [FromRoute]string datKey)
        {
            return Ok($"/{boardKey}/dat/{datKey}.dat");
        }
    }
}