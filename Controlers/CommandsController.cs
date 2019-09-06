using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cmdapi.Models;
// using Microsoft.EntityFrameworkCore;

namespace cmdapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        private readonly CommandContext _context;

        public CommandsController (CommandContext context) => _context = context;
 
        // GET api/commands : All items
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            return _context.CommandItems;
        }

        // GET api/commands/n : specific item
        [HttpGet("{Id}")]
        public ActionResult<Command> GetItem(int id)
        {
            var commandItem = _context.CommandItems.Find(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return commandItem;
        }
    }
}