using DAL;
using Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Repositories
{
    public class BookDetails : IBook
    {

        BookInfo bs = new BookInfo();
        public void Delete(int id)
        {
            Book book = bs.books.Find(id);
            bs.books.Remove(book);
            bs.SaveChanges();
        }
        public List<Book> GetAll()
        {
            var items = bs.books.ToList();
            return items;
        }
        public void Insert(Book dt)
        {
            Book book = new Book();
            book.Name = dt.Name;
            book.Description = dt.Description;
            book.ISBN = dt.ISBN;
            var result = bs.books.Add(book);
            bs.SaveChanges();
        }
        public void Update(Book dt, int id)
        {
            var details = bs.books.Where(s => s.Id == id).FirstOrDefault<Book>();
            details.Name = dt.Name;
            details.Description = dt.Description;
            details.ISBN = dt.ISBN;
            bs.SaveChanges();
        }
        public void Save()
        {
            bs.SaveChanges();
        }
    }
}
