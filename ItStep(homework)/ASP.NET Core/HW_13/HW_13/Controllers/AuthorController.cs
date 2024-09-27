using DB;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW_13.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly Context _context = new();

    [HttpGet("GetAuthors")]
    public async Task<ActionResult<List<Author>>> GetAuthors()
    {
        List<Author> authors = new();
        try
        {
            authors = await _context.Authors.ToListAsync();
        }
        catch (ArgumentNullException)
        {
            return NotFound();
        }
        finally
        {
            _context.Dispose();
        }
        
        return Ok(authors);
    }

    [HttpGet("GetAuthorsByName")]
    public async Task<ActionResult<Author>> GetAuthorsByName(string name)
    {
        Author author = new();
        try
        {
            author = await _context.Authors.Where(a => a.FirstName == name).FirstAsync();
        }
        catch (ArgumentNullException)
        {
            return NotFound();
        }
        finally
        {
            _context.Dispose();
        }

        return Ok(author);
    }
    
    [HttpPost("AddAuthor")]
    public async Task<IActionResult> AddAuthor(Author author)
    {
        if ((await _context.Authors.ToListAsync()).Any(a => a.ToString() == author.ToString()))
        {
            return Conflict("Author already exists");
        }

        try
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Author not added");
        }
        finally
        {
            _context.Dispose();
        }

        return Ok();
    }

    [HttpDelete("DeleteAuthor")]
    public async Task<IActionResult> DeleteAuthor(int id)
    {
        try
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Author not deleted");
        }
        finally
        {
            _context.Dispose();
        }

        return Ok();
    }

    [HttpPut("UpdateAuthor")]
    public async Task<IActionResult> UpdateAuthor(Author author)
    {
        try
        {
            var existingAuthor = await _context.Authors.FindAsync(author.Id);
            if (existingAuthor == null)
            {
                return NotFound();
            }
            
            existingAuthor.FirstName = author.FirstName;
            existingAuthor.LastName = author.LastName;
            
            _context.Authors.Update(existingAuthor);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return BadRequest("Author not updated");
        }
        finally
        {
            _context.Dispose();
        }
        
        return Ok();
    }
}