using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DAL
{
    public class BookInfo:DbContext
    {
        public BookInfo() : base("BookInfo")
        {
        }
        public DbSet<Book> books { get; set; }
    }
}
