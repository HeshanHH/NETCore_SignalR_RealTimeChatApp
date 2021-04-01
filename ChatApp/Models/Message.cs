using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Text{ get; set; }
        public DateTime Timestamp{ get; set; }

    }
}
