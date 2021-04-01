using ChatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Database
{
    // IdentityDbContext will scaffold all the identity tables
    // By specifing IdentityDbContext<User> we can create that user.
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        // register our models
        public DbSet<Chat> Chats{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        
    }
}
