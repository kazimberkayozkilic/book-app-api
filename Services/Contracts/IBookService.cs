﻿using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IBookService
    {
        Task<(IEnumerable<ExpandoObject>, MetaData metaData)> GetAllBooksAsync(BookParameters bookParameters,bool trackChanges);
        Task<BookDto> GetOneBookByIdAsync(int id, bool trackChanges);
        Task<BookDto> CreateOneBookAsync(BookDtoForInsertion book);
        Task  UpdateOneBookAsync(int id,BookDtoForUpdate bookDto, bool trackChanges);
        Task DeleteAsync(int id, bool trackChanges);
    }
}
