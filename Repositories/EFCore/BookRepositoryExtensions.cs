using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public static class BookRepositoryExtensions
    {
        public static IQueryable<Book> FilterBooks(this IQueryable<Book> books, 
            uint MinPrice, uint MaxPrice) =>
            books.Where(book => book.Price >= MinPrice && book.Price <= MaxPrice);
    }
}
