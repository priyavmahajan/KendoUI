using DAL;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Repository
{
    public class BookStoreDetail : IBookStoreDetails
    {
        BookStoreInfo bs = new BookStoreInfo();
        public IEnumerable<BookStoreM> GetAll()
        {
            var items = bs.bookStoreMs.ToList();
            return items;
        }

        public IEnumerable<BookStoreM> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(BookStoreM dt)
        {
            throw new NotImplementedException();
        }
    }
}
