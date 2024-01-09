# Infrastructure Module

This module contains all the implementations of the abstractions defined in the Core project. It usually includes code that interacts with external resources such as file systems, web services, SMTP, and so on. In our case, it refers to the data persistence mechanisms, external services like emailing, time providers, and identity management.

## Overview

The `Infrastructure` module includes several key components:

- Persistence Layer: Implementation of repositories and the unit of work pattern that deal with the database using Entity Framework Core.
- Identity Management: Services that manage user authentication and authorization processes.
- External Services: This can include email sending services, cloud storage services, etc.
- Configuration: Classes that load and hold configurations needed for infrastructure services.

Keep this documentation updated as you add more details to the module or change existing functionality.