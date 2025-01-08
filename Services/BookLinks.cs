using Entities.DataTransferObjects;
using Entities.LinkModels;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Net.Http.Headers;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookLinks : IBookLinks
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IDataShaper<BookDto> _dataShaper;

        public BookLinks(IDataShaper<BookDto> dataShaper, LinkGenerator linkGenerator)
        {
            _dataShaper = dataShaper;
            _linkGenerator = linkGenerator;
        }

        public LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto, string fields, HttpContext HttpContext)
        {
            var shapedBooks = ShapedData(booksDto, fields);
            if (ShouldGenerateLinks(HttpContext))
            {
                return ReturnLinkedBooks(booksDto, fields, HttpContext, shapedBooks);
            }
            return ReturnShapedBooks(shapedBooks);
        }

        private LinkResponse ReturnLinkedBooks(IEnumerable<BookDto> booksDto, string fields, HttpContext httpContext, List<Entity> shapedBooks)
        {
            var bookDtoList = booksDto.ToList();
            for (int index = 0; index < bookDtoList.Count; index++)
            {
                var bookLinks = CreateForBook(httpContext, bookDtoList[index].Id, fields);
                shapedBooks[index].Add("Links", bookLinks);
            }
            var bookCollection = new LinkCollectionWrapper<Entity>();
            bookCollection.AddRange(shapedBooks);
            return new LinkResponse { HasLinks = true, LinkedEntities = bookCollection };
        }

        private List<Link> CreateForBook(HttpContext httpContext, int ıd, string fields)
        {
            var links = new List<Link>()
            {
                new Link("a1","b1","c1"),
                new Link("a2","b2","c2")
            };
            return links;
        }

        private LinkResponse ReturnShapedBooks(List<Entity> shapedBooks)
        {
            return new LinkResponse() { ShapedEntities = shapedBooks };
        }

        private bool ShouldGenerateLinks(HttpContext httpContext)
        {
            var mediaType = (MediaTypeHeaderValue)httpContext.Items["AcceptHeaderMediaType"];
            return mediaType.SubTypeWithoutSuffix.EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
        }

        private List<Entity> ShapedData(IEnumerable<BookDto> booksDto, string fields)
        {
            return _dataShaper.ShapeData(booksDto, fields).Select(s => s.Entity).ToList();
        }

    }
}

