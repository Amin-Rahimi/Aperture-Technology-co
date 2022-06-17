using ApiLike.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book {Id = 1, Title = "Shabhaye Pishavor", Author = "WaezZadah", PublicationYear = 1997, CallNumber="202 343 8765", IsAvailable=true},
            new Book {Id = 2, Title = "Qiyamat", Author = "Someone", PublicationYear = 1990, CallNumber="202 343 8765", IsAvailable=true},
            new Book {Id = 3, Title = "Java", Author = "William Joseph", PublicationYear = 2020, CallNumber="202 343 8765", IsAvailable=true},
            new Book {Id = 4, Title = "C#", Author = "Khodada Azizian", PublicationYear = 2017, CallNumber="202 343 8765", IsAvailable=true},
            new Book {Id = 5, Title = "Artificial Intelligence", Author = "Amin Mandegar", PublicationYear = 1997, CallNumber="202 343 8765", IsAvailable=true},
            
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books;
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
