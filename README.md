# Virtual Library Backend

## Overview
This backend application is designed to manage a virtual library system efficiently and effectively. The system facilitates the registration and management of books and students. It also allows administrators to control system settings, and librarians to manage book rental processes, including registration, renting, and returning of books.

### Features
- Book management (CRUD)
- Student management (CRUD)
- Administrator and librarian management, with role-specific access controls
- Book renting and return with automated status updates
- System setting management, including loan duration settings

## Getting Started
To get this application up and running, follow these steps:

1. Install .NET Core 5 and set up SQL Server.
2. Clone the project repository.
3. Navigate to the project directory and restore the required packages using `dotnet restore`.
4. Configure the app settings in **appsettings.json** with your SQL Server connection details.
5. To create the initial database schema, use Entity Framework migrations with `dotnet ef migrations add InitialCreate` followed by `dotnet ef database update`.
6. Compile the code using `dotnet build` and run the application using `dotnet run`.

## System Architecture
The architecture of this application follows Robert C. Martin’s Clean Architecture principles, organized into the following components:
- **Core**: Includes domain entities and use case interfaces.
- **Application**: Contains implementation of use cases, services, DTOs, and mapping profiles.
- **Infrastructure**: Implements external concerns like database context, repositories, identity management, and other external services (e.g., email).
- **Persistence**: Provides the Entity Framework Core DbContext and entity configurations.
- **Presentation**: Handles the user interface for the application, primarily consisting of controllers and view models.
- **Root**: The entry point for the application, including configuration and startup files.

## Development Guidelines
- Follow Clean Architecture principles.
- Use dependency inversion to ensure that higher-level modules do not depend on lower-level modules.
- Adhere to the project's coding standards as defined in the **.editorconfig**.
- Write clear and maintainable code with proper documentation.
- Cover your code with unit tests where practical.

## Contribution
Before pushing your code to the repo, please ensure that:
- The code compiles without errors.
- All unit tests pass.
- The code has been reviewed by at least one other team member.

Thank you for contributing to the Virtual Library backend project! Happy coding!