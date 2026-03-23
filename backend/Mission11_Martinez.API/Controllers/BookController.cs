using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission11_Martinez.API.Data;

namespace Mission11_Martinez.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookStoreDbContext _bookContext;
        
        public BookController(BookStoreDbContext temp) => _bookContext = temp;
        
        
        public IEnumerable<Book> GetBooks()
        {
            var something = _bookContext.Books.ToList();
            
            return something;
        }
    }
}