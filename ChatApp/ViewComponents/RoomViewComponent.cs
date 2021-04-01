using ChatApp.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.ViewComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public RoomViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var chats = _dbContext.Chats.ToList();
            return View(chats);
        }
    }
}
