using Library.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Desktop.Services
{
    public interface IBookRepository
    {
        Task<List<Book>> GetBooks();
        Task<Book> GetBook(int id);
        Task<Book> CreateBook(Book newBook);
        Task<Book> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<Book> FirstBook(string name);
    }
}
