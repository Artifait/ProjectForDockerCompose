using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ItemsController(AppDbContext db) => _db = db;

        [HttpGet]
        public IActionResult GetAll() => Ok(_db.Items.ToList());

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = item.Id }, item);
        }
    }
}