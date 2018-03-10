using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook.Models
{
    public class GuestbookEntry
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Message { get; set; }
        public DateTime DateCreated { get; set; }
    }
}