using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<OrderItem> Get()
        {
            return _context.OrderItem.ToList();
        }
    }
}
