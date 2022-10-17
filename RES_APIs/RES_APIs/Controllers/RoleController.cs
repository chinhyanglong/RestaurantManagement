using Microsoft.AspNetCore.Mvc;
using RES_APIs.Data;
using RES_APIs.Models;

namespace RES_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IEnumerable<Role> Get()
        {
            return _context.Role.ToList();
        }

        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return _context.Role.Where(p=>p.Id == Id).FirstOrDefault();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Role Post([FromQuery] Role Role)
        {
            _context.Role.Add(Role);
            _context.SaveChanges();
            return Role;
        }
    }
}
