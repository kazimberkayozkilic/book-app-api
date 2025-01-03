using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Extensions
{
    public static class BookRepositoryExtensions
    {
        public static IQueryable<Book> FilterBooks(this IQueryable<Book> books,
            uint MinPrice, uint MaxPrice) =>
            books.Where(book => book.Price >= MinPrice && book.Price <= MaxPrice);

        public static IQueryable<Book> Search(this IQueryable<Book> books, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return books;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return books.Where(book => book.Title.ToLower().Contains(lowerCaseSearchTerm));
        }
    }
}
