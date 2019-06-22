using Anchorage.Server.Models;
using Anchorage.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Anchorage.Server.Controllers
{
    [Route("/{boardKey}/SETTING.TXT")]
    [Controller]
    public class LegacySettingTxtController : ControllerBase
    {
        private readonly MainContext _context;

        public LegacySettingTxtController(MainContext context)
        {
            _context = context;
        }
        [Route("")]
        [HttpGet]
        [Produces("text/plain; charset=shift_jis")]
        public async Task<IActionResult> GetSettingTxt([FromRoute] string boardKey)
        {
            var board = _context.Boards.FirstOrDefault(x => x.BoardKey == boardKey);
            var sb = new StringBuilder();
            var boardType = typeof(Board);
            var members = boardType.GetProperties();
            foreach (var item in members)
            {
                var attributes = item.GetCustomAttributes(typeof(SettingTxtAttribute));
                foreach (var attribute in attributes)
                {
                    var settingTxtAttr = attribute as SettingTxtAttribute;
                    if (settingTxtAttr != null)
                    {
                        sb.AppendLine(settingTxtAttr.Name + "=" + (string)boardType.GetProperty(item.Name).GetValue(board));
                    }
                }
            }
            return Ok(sb.ToString());
        }
    }
}
