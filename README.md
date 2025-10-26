# Funsadek.ECommerce.Microservices using .NET Aspire

This is a sample e-commerce microservices solution built with .NET Aspire, consisting of a catalog service, order service, and notification worker.

## Architecture

- **Funsadek.AppHost**: The Aspire app host that orchestrates the services.
- **Funsadek.CatalogService**: ASP.NET Core Web API for managing products.
- **Funsadek.OrderService**: ASP.NET Core Web API for managing orders, depends on the catalog service.
- **Funsadek.NotificationWorker**: .NET Worker Service for handling notifications.
- **Funsadek.Shared**: Shared models and entities.

## Prerequisites

- .NET 9 SDK
- .NET Aspire workload: `dotnet workload install aspire`

## Setup and Run

1. Clone the repository:

   ```bash
   git clone https://github.com/olusolaadek/Funsadek.ECommerce.Microservices.git
   cd Funsadek.ECommerce.Microservices
   ```

2. Restore NuGet packages:

   ```bash
   dotnet restore
   ```

3. Run the application using Aspire:

   ```bash
   dotnet run --project Funsadek.AppHost
   ```

   This will start the Aspire dashboard and launch all services. The dashboard will be available at `http://localhost:15888` (or similar port).

## Testing the APIs

Use the `.http` files in each service project to test the endpoints:

- `Funsadek.CatalogService/Funsadek.CatalogService.http`: Test product CRUD operations.
- `Funsadek.OrderService/Funsadek.OrderService.http`: Test order CRUD operations.

The services use in-memory databases for simplicity, seeded with sample data.