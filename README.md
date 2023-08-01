# StructureNet 🔮

This repository contains an example project developed in .NET Core, following a robust and modular architecture for web applications. The goal of this project is to provide a clear and scalable blueprint adhering to the best design practices in .NET Core.

## Architecture

The project architecture is based on the principle of separation of concerns, facilitating a structured and maintainable development process. Below are the key folders and their functionalities:

### 📁 `Persistence` (Persistencia)

This folder contains logic related to data access and persistence. Here, we define entities, the database context, and repositories that interact with the database. This layer is responsible for CRUD operations (Create, Read, Update, Delete) and object-to-database entity mapping.

### 📁 `Domain` (Dominio)

In this folder, we define the core business logic of the application. It houses domain classes representing business concepts and rules. This layer is independent of infrastructure and should be as agnostic as possible regarding concrete implementation details.

### 📁 `Application` (Aplicacion)

The files located here hold the application logic, acting as intermediaries between the domain layer and the presentation layer (API). In this layer, we implement use cases and orchestrate operations involving multiple domain entities.

### 📁 `API`

This folder houses the Application Programming Interface (API) for our application. We use the MVC (Model-View-Controller) pattern to handle HTTP requests, and controllers communicate with the application layer to perform actions and retrieve data. This API serves as the entry point for clients and external applications.

## Requirements

Before running this project, make sure you have the following installed:

- .NET Core SDK 3.1 or higher

## Skills 🛠
  C#, .NETCore

## Deployment

1. Clone this repository to your local machine.
2. Open a terminal and navigate to the project folder.
3. Run `dotnet restore` to restore project dependencies.
4. Navigate to the `API` folder using the `cd API` command.
5. Run `dotnet run` to start the API.
6. Open your browser and navigate to `http://localhost:5000` to test the API.

## Documentation

[C# docs](https://learn.microsoft.com/en-us/dotnet/csharp/)

## Support

For support, email roolandoor@gmail.com or join our Slack channel.

## Authors

- [@rolando-r](https://www.github.com/rolando-r)

## 🔗 Links
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/rolando-rodriguez-garcia)

Feel free to explore the project and contribute to making it even better! 🚀