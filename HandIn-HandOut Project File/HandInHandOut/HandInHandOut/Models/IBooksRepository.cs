using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Models
{
    public interface IBooksRepository
    {
        Books GetBooks(int Id);
        IEnumerable<Books> GetAllBooks();
        Books Add(Books book);
        Books UpdateBooks(Books book);
        Books Delete(int id);
    }
}
