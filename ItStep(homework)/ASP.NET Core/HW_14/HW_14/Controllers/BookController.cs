using DB;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW_13.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly Context _context = new();

    [HttpGet("GetBooks")]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        List<Book> books = new();
        try
        {
            books = await _context.Books.ToListAsync();
        }
        catch (ArgumentNullException)
        {
            return NotFound();
        }
        finally
        {
            _context.Dispose();
        }

        return Ok(books);
    }

    [HttpGet("GetBooksByAuthor")]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthor(int authorId)
    {
        List<Book> books = new();
        try
        {
            books = await _context.Books.Where(b => b.Author.Id == authorId).ToListAsync();
        }
        catch (ArgumentNullException)
        {
            return NotFound();
        }
        finally
        {
            _context.Dispose();
        }

        return Ok(books);
    }

    [HttpPost("GetBooksByPriceRange")]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPriceRange(decimal start, decimal end)
    {
        List<Book> books = new();
        try
        {
            books = await _context.Books.Where(b => end >= b.Price && start <= b.Price).ToListAsync();
        }
        catch (ArgumentNullException)
        {
            return NotFound();
        }
        finally
        {
            _context.Dispose();
        }

        return Ok(books);
    }

    [HttpPost("AddBook")]
    public async Task<IActionResult> AddBook(Book book)
    {
        if ((await _context.Books.ToListAsync()).Any(b => b.ToString() == book.ToString()))
        {
            return Conflict("Book already exists");
        }

        try
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Book not added");
        }
        finally
        {
            _context.Dispose();
        }

        return Ok();
    }

    [HttpDelete("DeleteBook")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        try
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Book not deleted");
        }
        finally
        {
            _context.Dispose();
        }

        return Ok();
    }

    [HttpPut("UpdateBook")]
    public async Task<IActionResult> UpdateBook(Book book)
    {
        try
        {
            var existingBook = await _context.Books.FindAsync(book.Id);
            if (existingBook == null)
            {
                return NotFound();
            }
            
            existingBook.Name = book.Name;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;
            existingBook.Description = book.Description;
            
            _context.Books.Update(existingBook);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Book not updated");
        }
        finally
        {
            _context.Dispose();
        }
        
        return Ok();
    }
}