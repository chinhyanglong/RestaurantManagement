using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<Order> Get()
        {
            return _context.Order.ToList();
        }
    }
}
