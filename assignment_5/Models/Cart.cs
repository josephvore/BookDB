using System.Collections.Generic;
using System.Linq;
namespace assignment_5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines
            .Where(p => p.Book.BookID == book.BookID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        //Removing the line
        public virtual void RemoveLine(Book book) =>
        Lines.RemoveAll(l => l.Book.BookID == book.BookID);

        //Computing total value
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Book.Price * e.Quantity);

        //Clearing a line
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}