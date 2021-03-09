using assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using assignment_5.Models.ViewModels;

namespace assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;
        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Items per page variable that is set to = 5
        public int PageSize = 5;

        //Controller method with an action of Index()
        public IActionResult Index(string category, int pageNum = 1)
        {
            //View Model
            return View(new ProjectListViewModel
            {
                Books = _repository.Books
                    .Where(b => category == null || b.Category == category)
                    .OrderBy(p => p.BookID)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),
                PageInfo = new PageInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,

                    //Add the ability to filter by category in the Controller
                    TotalNumItems = category == null ? _repository.Books.Count() :
                    _repository.Books.Where(x => x.Category == category).Count()
                },
                CurrentCategory =  category

            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
