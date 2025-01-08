using Entities.DataTransferObjects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;
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
        public LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto, string fields, HttpContext HttpContext)
        {
            throw new NotImplementedException();
        }
    }
}
