using Entities.DataTransferObjects;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BooksController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _manager.BookService.GetAllBooks(false);
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {

            var book = _manager.BookService.GetOneBookById(id, false);
            return Ok(book);

        }


        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {

            if (book is null)

                return BadRequest();

            _manager.BookService.CreateOneBook(book);

            return Ok(book);

        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] BookDtoForUpdate bookDto)
        {

            if (bookDto is null)
                return BadRequest();

            _manager.BookService.UpdateOneBook(id, bookDto, false);

            return NoContent();//204




        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name = "id")] int id)
        {
            _manager.BookService.Delete(id, false);
            return NoContent(); //204
        }

    }
}
