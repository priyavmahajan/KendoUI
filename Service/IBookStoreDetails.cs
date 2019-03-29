using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service
{
    public interface IBook
    {
        List<Book> GetAll();
        void Insert(Book dt);
        void Update(Book dt, int id);
        void Delete(int id);
        void Save();
    }
}
