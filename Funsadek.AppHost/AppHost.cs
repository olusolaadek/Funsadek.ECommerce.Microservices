var builder = DistributedApplication.CreateBuilder(args);

var catalog = builder.AddProject<Projects.Funsadek_CatalogService>("catalog");

var order = builder.AddProject<Projects.Funsadek_OrderService>("order").WaitFor(catalog); // order depends on catalog

var notifications  = builder.AddProject<Projects.Funsadek_NotificationWorker>("notifications");

builder.Build().Run();
 