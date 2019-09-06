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
 
        // GET all results:
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            return _context.CommandItems;
        }
    }
}