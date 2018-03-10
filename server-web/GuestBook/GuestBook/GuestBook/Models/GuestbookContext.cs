using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace GuestBook.Models
{
    public class GuestbookContext : DbContext
    {
        public GuestbookContext() : base("GuestBookDB")
        {

        }

        public DbSet<GuestbookEntry> Entries { get; set; }
    }
}