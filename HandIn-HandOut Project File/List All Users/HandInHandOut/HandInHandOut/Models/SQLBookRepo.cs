using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Models
{
    public class SQLBookRepo : IBooksRepository
    {
        private readonly AppDbContext context;
        public SQLBookRepo(AppDbContext context)
        {
            this.context = context;
        }
        
        public Books Add(Books book)
        {
            context.Book.Add(book);
            context.SaveChanges();
            return book;
        }

        public Books Delete(int id)
        {
            Books book=context.Book.Find(id);
            if(book!= null)
            {
                context.Book.Remove(book);
                context.SaveChanges();
            }
            return book;
        }

        public IEnumerable<Books> GetAllBooks()
        {
            return context.Book;
        }

        public Books GetBooks(int Id)
        {
            return context.Book.Find(Id);
        }

        public Books UpdateBooks(Books book)
        {
            var bookChanges = context.Book.Attach(book);
            bookChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return book;
        }
    }
}
