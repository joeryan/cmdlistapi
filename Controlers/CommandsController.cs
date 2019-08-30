using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
// using CommandAPI.Models;
// using Microsoft.EntityFrameworkCore;

namespace cmdapi.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    public class CommandsController : ControllerBase 
    {
        // simple GET:
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"hard", "coded", "string"};
        }
    }
}