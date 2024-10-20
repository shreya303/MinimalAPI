# MinimalAPI
A c# Minimal API template for a headstart
# MinimalAPI
A c# Minimal API template for a headstart

Welcome to this Minimal API project using .NET 8.0! This guide will walk you through the setup, development, and usage of this API. Minimal APIs are lightweight APIs that allow developers to quickly define routes and business logic in a simple and concise way, without needing complex configurations.

**Overview**
This project demonstrates how to use Minimal APIs to build RESTful web services with .NET 8.0. It follows a clean architecture, splitting the project into layers like Infrastructure, Core, and Presentation.

Infrastructure Layer: Handles data access and external services.
Core Layer: Contains the domain entities and application logic.
Presentation Layer: Exposes the API endpoints to the client.
Minimal APIs provide a simple, high-performance framework for building APIs. All routes and configurations are defined in the Program.cs or through specific Endpoints classes.

**Project Structure**
Here is a brief overview of the project structure:

MinimalAPI/

├── Application/              # Application logic and services

├── Core/                     # Core business models and domain logic

├── Infrastructure/           # Data access and database setup
├── Presentation/             # API endpoints and configurations
**Prerequisites**
Before running this project, ensure that the following are installed:
-> .NET 8 SDK
-> Visual Studio 2022 or VS Code