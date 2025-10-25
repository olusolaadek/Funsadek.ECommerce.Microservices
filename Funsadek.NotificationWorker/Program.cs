using Microsoft.EntityFrameworkCore;
using Funsadek.NotificationWorker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddDbContext<NotificationDbContext>(options => options.UseInMemoryDatabase("notifications"));

var host = builder.Build();
host.Run();
