using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UnitController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<Unit> Get()
        {
            return _context.Unit.ToList();
        }
    }
}
