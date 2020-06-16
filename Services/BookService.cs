using CS321_W3D1_BookAPI.Data;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;

        public BookService(BookContext myContext)
        {
            _bookContext = myContext;
        }
        public Book Add(Book newBook)
        {
            
        }

        public void Delete(Book book)
        {
            Delete(book);
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book Update(Book updatedBook)
        {
            throw new NotImplementedException();
        }
    }
}
