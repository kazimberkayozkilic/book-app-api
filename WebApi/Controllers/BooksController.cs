using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.EFCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public BooksController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            try
            {
                return Ok(_context.Books.ToList());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {
            try
            {
                var book = _context.Books.Where(x => x.Id == id).SingleOrDefault(); //linq sorgusu

                if (book == null)
                {
                    return NotFound();
                }

                return Ok(book);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {
            try
            {
                if (book is null)

                    return BadRequest();

                _context.Books.Add(book);
                _context.SaveChanges();
                return StatusCode(201, book);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] Book book)
        {
            try
            {
                var entity = _context.Books.Where(b => b.Id.Equals(id)).SingleOrDefault();

                if (entity == null)
                {
                    return NotFound();
                }
                if (id != book.Id)
                {
                    return BadRequest();
                }
                entity.Title = book.Title;
                entity.Price = book.Price;
                _context.SaveChanges();
                return Ok(book);

            }
            catch ( Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entity = _context.Books.Where(b => b.Id.Equals(id)).SingleOrDefault();
                if (entity == null)
                {
                    return NotFound();
                }
                _context.Books.Remove(entity);
                _context.SaveChanges();
                return Ok(entity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

        }

    }
}
