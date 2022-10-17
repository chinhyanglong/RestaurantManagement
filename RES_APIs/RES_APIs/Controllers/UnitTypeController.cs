using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UnitTypeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<UnitType> Get()
        {
            return _context.UnitType.ToList();
        }
    }
}
