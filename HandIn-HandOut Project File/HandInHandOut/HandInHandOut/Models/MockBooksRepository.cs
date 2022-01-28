using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Models
{
    public class MockBooksRepository : IBooksRepository
    {
        private List<Books> _booksList;


        public MockBooksRepository()
        {
            _booksList = new List<Books>()
            {
                new Books() { id = 1, Name = "C# For Dummies",Author="Suboor",Major=Major.ComputerScience, BuyingAmount=20,RentingAmount=0.10, IsAvailable = Available.Yes ,NumberOfBooksAvailable=10},
                new Books() { id = 2, Name = "Math For Dummies", Author = "Nawaz", Major =Major.Economics, BuyingAmount = 15,RentingAmount=0.5, IsAvailable = Available.Yes ,NumberOfBooksAvailable=20},
                new Books() { id = 3, Name = "Plants For Dummies",Author="Vinay",Major=Major.Biology,  BuyingAmount=20,RentingAmount=0.20, IsAvailable = Available.No,NumberOfBooksAvailable=0},
                new Books() { id = 4, Name = "Politics For Dummies",Author="Rehman",Major=Major.PoliticalScience, BuyingAmount=20,RentingAmount=0.20, IsAvailable = Available.Yes,NumberOfBooksAvailable=5}
            };
        }

        public Books Add(Books book)
        {
            book.id= _booksList.Max(e => e.id) + 1;
            _booksList.Add(book);
            return book;
        }

        public Books Delete(int id)
        {
           Books book=_booksList.FirstOrDefault(e => e.id == id);
            if(book != null)
            {
                _booksList.Remove(book);
            }
            return book;
        }

        public IEnumerable<Books> GetAllBooks()
        {
            return _booksList;
        }

        public Books GetBooks(int Id)
        {
            return _booksList.FirstOrDefault(e => e.id == Id);
        }

        public Books UpdateBooks(Books bookChanges)
        {
            Books book = _booksList.FirstOrDefault(e => e.id == bookChanges.id);
            if (book != null)
            {
                book.Name = bookChanges.Name;
                book.Author = bookChanges.Author;
                book.Major = bookChanges.Major;
                book.BuyingAmount = bookChanges.BuyingAmount;
                book.RentingAmount = bookChanges.RentingAmount;
                book.NumberOfBooksAvailable = bookChanges.NumberOfBooksAvailable;
                book.IsAvailable = bookChanges.IsAvailable;
            }
            return book;
        }
    }
}
