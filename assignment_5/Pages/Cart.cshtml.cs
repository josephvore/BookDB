using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using assignment_5.Infrastructure;
using assignment_5.Models;
using System.Linq;


namespace assignment_5.Pages
{

 public class CartModel : PageModel
    {
        private IBookRepository repository;

        public CartModel(IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books
            .FirstOrDefault(p => p.BookID == bookId);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.Book.BookID == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}