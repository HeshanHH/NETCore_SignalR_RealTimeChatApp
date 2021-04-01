using ChatApp.Database;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Properties
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index() => View();

        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {
            var chat = _dbContext.Chats.FirstOrDefault(x => x.Id == id);

            return View(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            _dbContext.Chats.Add(new Chat
            {
                Name = name,
                Type = ChatType.Room,
            });
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
