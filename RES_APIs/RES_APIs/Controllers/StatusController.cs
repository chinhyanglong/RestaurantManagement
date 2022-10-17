using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<Status> Get()
        {
            return _context.Status.ToList();
        }
    }
}
