using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PersonalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_bookRepository.GetAllBooks());
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(DataAccess.Entities.Book book)
        {
            return Ok(_bookRepository.CreateBook(book));
        }
    }
}
