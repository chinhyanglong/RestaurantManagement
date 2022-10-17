using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestTableController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GuestTableController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<GuestTable> Get()
        {
            return _context.GuestTable.ToList();
        }
    }
}
