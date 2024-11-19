using DB;
using DB.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW_15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(BookStoreContext context) : ControllerBase
    {
        private readonly BookStoreContext _context = context;
        
        [HttpGet]
        public IActionResult GetBooks() {
            return Ok(_context.Books.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id) {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpGet("authors/{authorId}")]
        public IActionResult GetBooksByAuthor(int authorId) {
            var books = _context.Books.Where(b => b.AuthorId == authorId).ToList();
            return Ok(books);
        }

        [HttpGet("price-range")]
        public IActionResult GetBooksByPriceRange(decimal minPrice, decimal maxPrice) {
            var books = _context.Books.Where(b => b.Price >= minPrice && b.Price <= maxPrice).ToList();
            return Ok(books);
        }

        [HttpPost]
        [EnableCors("Restricted")] // Додавання
        public IActionResult AddBook([FromBody] Book book) {
            _context.Books.Add(book);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("updateBook/{id}")]
        [EnableCors("Restricted")] // Зміна
        public IActionResult UpdateBook(int id, [FromBody] Book book) {
            if (id != book.Id) return BadRequest();
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [EnableCors("DatabaseOnly")] // Видалення
        public IActionResult DeleteBook(int id) {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();
            _context.Books.Remove(book);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
