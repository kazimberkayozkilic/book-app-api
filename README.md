Book CRUD Application with ASP.NET Core Web API
Project Description
This project is a Book CRUD Application developed using ASP.NET Core Web API. The application allows you to perform basic operations like adding, updating, deleting, and listing books. It also includes security features like authentication (JWT, Identity, Refresh Token), rate limiting, and restrictions. The API offers user-friendly and flexible functionality with features like data shaping, pagination, sorting, searching, and more.

Tools and Features Used
JWT, Identity, and Refresh Token: For user authentication and authorization.
Rate Limiting and Restrictions: To limit API usage.
NLog Implementation: For logging and error tracking.
Global Error Handling: Centralized error management for all scenarios.
AutoMapper: For object-to-object mapping.
Content Negotiation: The API can return data in different formats like JSON and XML.
Validation: Validates incoming API data.
Asynchronous Code: Asynchronous operations for better performance.
Action Filters: Custom filters for API actions.
Pagination: Breaks down large datasets into pages.
Filtering: Allows users to filter data.
Searching: Enables searching through data.
Sorting: Sorts data based on specific criteria.
Data Shaping: Returns only necessary fields from the data.
HATEOAS: Adds self-descriptive links to the API responses.
HEAD and OPTIONS: Supports HTTP methods HEAD and OPTIONS for metadata.
Root Documentation: The root documentation for the API.
Versioning: Manages different versions of the API.
Caching: Implements caching for faster response times.
Entity Framework Core: ORM for database operations.
Project Layers
This project consists of the following layers:

Entities: Database models.
Presentation: API controllers and view models.
Repositories: Data access (CRUD operations).
Services: Business logic and services.
WebApi: The overall API configuration and startup.
Extensions Used
Microsoft.AspNetCore.Identity.EntityFrameworkCore 6.0.0
Microsoft.AspNetCore.Mvc.Abstractions 2.0.0
Marvin.Cache.Headers 6.0.0
Microsoft.AspNetCore.Mvc.Core 2.2.5
Microsoft.AspNetCore.Mvc.Versioning 5.0.0
Microsoft.EntityFrameworkCore 6.0.10
Microsoft.EntityFrameworkCore.SqlServer 6.0.10
Microsoft.Extensions.Configuration 8.0.0
System.Linq.Dynamic.Core 1.5.1
AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1
Microsoft.AspNetCore.JsonPatch 9.0.0
NLog.Extensions.Logging 5.3.15
System.IdentityModel.Tokens.Jwt 6.14.1
