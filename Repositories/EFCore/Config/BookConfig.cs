using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder1)
        {
            builder1.HasData(new Book
            {
                Id = 1,
                Title = "Book 1",
                Price = 15
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Price = 18
            },
            new Book
            {
                Id = 3,
                Title = "Book 3",
                Price = 11
            }

            );
        }
    }
}

