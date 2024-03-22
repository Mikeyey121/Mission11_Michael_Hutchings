using Microsoft.AspNetCore.Mvc;
using Mission11_Michael_Hutchings.Models;
using Mission11_Michael_Hutchings.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Michael_Hutchings.Controllers
{
    public class HomeController : Controller
    {
        // Creating a private variable of type IBookstoreRepository

        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        // This is our Index action which takes care of querying and passing the books to the view
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var books = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(books);
        }

    }
}
