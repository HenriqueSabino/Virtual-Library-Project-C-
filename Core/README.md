# Core Module

## Overview
This module is the heart of the Virtual Library Backend project. It contains the essential business rules and domain entities that define the fundamental logic and operations of the system. The Core module is designed with the principles of the Clean Architecture in mind, ensuring that our business logic is independent of frameworks, databases, and user interfaces.

## Entities
Entities are the domain objects that encapsulate the most fundamental business rules. For this project, they include:

- Book
- Student
- Librarian
- Administrator

## Interfaces
Interfaces define the contracts for the use cases and any database operations that will be performed. They are critical for achieving Dependency Inversion, a principle that ensures high-level modules don't depend on low-level modules.

The interfaces included in this module are:

- Repositories for basic CRUD operations on entities
- Use cases that encapsulate application-specific business rules

### Repository Interfaces
- IBookRepository
- IStudentRepository
- ILibrarianRepository
- IAdministratorRepository
- IUnitOfWork

### Use Case Interfaces
- IRegisterBookUseCase
- IManageBookUseCase
- IRegisterStudentUseCase
- IRentBookUseCase
- IReturnBookUseCase
- IRegisterLibrarianUseCase
- IRegisterAdministratorUseCase
- IManageLibrarianUseCase
- IManageAdministratorUseCase
- ISetLoanDurationUseCase

## Dependency Rules
All dependencies flow inwards, meaning that external modules can depend on the Core module, but the Core module must not depend on any other module.

## How to Extend
When adding new business rules or entities, make sure that they align with the existing conventions in the Core module. Any new logic should be encapsulated within use cases or entities and exposed via interfaces.

## Conclusion
The Core module is designed to be stable, well-tested, and flexible enough to accommodate future changes. By adhering to the principles outlined in Clean Architecture, we ensure our core business logic is resilient against changes in externals layers of the application.