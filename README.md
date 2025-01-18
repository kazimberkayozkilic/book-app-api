# Book CRUD Application with ASP.NET Core Web API

## Project Description
This project is a **Book CRUD Application** developed using **ASP.NET Core Web API**. It allows users to perform basic CRUD operations such as adding, updating, deleting, and retrieving books. The API also includes advanced features like **authentication (JWT, Identity, Refresh Token)**, **rate limiting**, and **restrictions** to enhance security and performance. The application is built with a focus on flexibility and scalability, offering key features like **data shaping**, **pagination**, **sorting**, **searching**, and more.

## Tools and Features Used

- **JWT, Identity, and Refresh Token**: Implements user authentication and authorization to securely manage user sessions.
- **Rate Limiting and Restrictions**: Controls API access by limiting the number of requests a user can make, reducing the risk of abuse.
- **NLog Implementation**: Provides a robust logging solution to track application errors and important events.
- **Global Error Handling**: Implements centralized error handling across the application to ensure consistency and improve user experience.
- **AutoMapper**: A tool to automatically map properties between objects, simplifying code and reducing redundancy.
- **Content Negotiation**: Allows the API to return data in multiple formats, such as JSON or XML, based on client requests.
- **Validation**: Ensures that incoming data is correct and meets defined rules before processing it.
- **Asynchronous Code**: Uses asynchronous programming techniques to optimize application performance and responsiveness.
- **Action Filters**: Custom filters applied to API actions to handle cross-cutting concerns like logging, validation, etc.
- **Pagination**: Divides large datasets into smaller, manageable pages, improving performance and usability.
- **Filtering**: Allows users to filter data based on specific criteria, improving data retrieval efficiency.
- **Searching**: Provides a search functionality to find data quickly by specific fields.
- **Sorting**: Enables data sorting based on various fields, allowing users to order data as needed.
- **Data Shaping**: Returns only the required fields from a data set, reducing overhead and improving response times.
- **HATEOAS (Hypermedia as the Engine of Application State)**: Adds self-descriptive links to API responses to guide users on available actions.
- **HEAD and OPTIONS**: Supports the HTTP methods HEAD and OPTIONS for retrieving metadata about resources.
- **Root Documentation**: The root API documentation provides a clear overview of the available endpoints and methods.
- **Versioning**: Manages different versions of the API, ensuring backward compatibility and smooth upgrades.
- **Caching**: Implements caching strategies to speed up data retrieval by storing previously fetched data.
- **Entity Framework Core**: The Object-Relational Mapping (ORM) framework for database interactions, making data access easier and more efficient.

## Project Layers
This project is divided into the following layers, each with specific responsibilities:

- **Entities**: Contains database models that represent the data structure in the application.
- **Presentation**: Includes API controllers, view models, and response formatting for client communication.
- **Repositories**: Handles data access and CRUD operations for interacting with the database.
- **Services**: Contains the business logic that manages application operations and interacts with the repository layer.
- **WebApi**: The configuration layer that sets up the ASP.NET Core Web API application, including routing, middleware, and services.

## Extensions Used
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore 6.0.0**: Enables Identity management with Entity Framework.
- **Microsoft.AspNetCore.Mvc.Abstractions 2.0.0**: Provides common MVC abstractions.
- **Marvin.Cache.Headers 6.0.0**: Implements cache headers in the application to optimize caching strategies.
- **Microsoft.AspNetCore.Mvc.Core 2.2.5**: Core MVC functionalities, including controllers and actions.
- **Microsoft.AspNetCore.Mvc.Versioning 5.0.0**: Adds API versioning support for managing multiple API versions.
- **Microsoft.EntityFrameworkCore 6.0.10**: Entity Framework Core for database interaction.
- **Microsoft.EntityFrameworkCore.SqlServer 6.0.10**: SQL Server provider for Entity Framework Core.
- **Microsoft.Extensions.Configuration 8.0.0**: Configures application settings and environment variables.
- **System.Linq.Dynamic.Core 1.5.1**: Enables dynamic LINQ queries for advanced filtering and sorting.
- **AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1**: Integration of AutoMapper with Microsoft Dependency Injection.
- **Microsoft.AspNetCore.JsonPatch 9.0.0**: Support for the JSON Patch format, allowing partial updates to resources.
- **NLog.Extensions.Logging 5.3.15**: Integration of NLog for logging and error tracking.
- **System.IdentityModel.Tokens.Jwt 6.14.1**: JWT support for authentication and authorization.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/username/repository-name.git
