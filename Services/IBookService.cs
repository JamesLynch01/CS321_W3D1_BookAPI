using CS321_W3D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Services
{
    public interface IBookService
    {
        //get all books
        IEnumerable<Book> GetAll();

        //get a book by id
        Book Get(int id);

        //add a new book
        Book Add(Book newBook);

        //update a book
        Book Update(Book updatedBook);

        //delete a book
        void Delete(Book book);
    }
}
