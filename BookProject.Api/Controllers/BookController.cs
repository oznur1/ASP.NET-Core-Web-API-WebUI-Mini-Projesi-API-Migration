using BookProject.Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;


namespace BookProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Book
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _context.Books.ToList();

            return Ok(response);
        }

        // GET: api/Book/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = _context.Books.Find(id);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        // POST: api/Book
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return Ok(book);
        }

        // PUT: api/Book/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Book book)
        {
            var existingBook = _context.Books.Find(id);

            if (existingBook is null)
                return NotFound();

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;

            _context.SaveChanges();

            return Ok(existingBook);
        }

        // DELETE: api/Book/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);

            if (book is null)
                return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return Ok(book);
        }
    }
}
