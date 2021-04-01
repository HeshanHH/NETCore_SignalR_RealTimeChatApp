﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{

    public class Chat
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages{ get; set; }
        public ICollection<User> Users{ get; set; }
        public ChatType Type{ get; set; }
        // prop for users
    }
}
