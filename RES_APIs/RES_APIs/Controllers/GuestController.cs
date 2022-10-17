using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GuestController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<Guest> Get()
        {
            return _context.Guest.ToList();
        }
    }
}
