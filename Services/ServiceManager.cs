﻿using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IAuthenticationService> _authencationService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger, UserManager<User> userManager , IConfiguration configuration ,IMapper mapper, IBookLinks bookLinks)
        {
            _bookService = new Lazy<IBookService>(() => new BookManager(repositoryManager, logger, mapper, bookLinks));
            _authencationService = new Lazy<IAuthenticationService>(() => new AuthenticationManager(logger, mapper, userManager, configuration));
        }

        public IBookService BookService => _bookService.Value;

        public IAuthenticationService AuthenticationService => _authencationService.Value;
    }
}
