using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5.Models
{

    //Both the repository interface and the implementation of that interface have been created
    public interface IBookRepository
    {
        IQueryable<Book> Books { get;  }
    }
}
