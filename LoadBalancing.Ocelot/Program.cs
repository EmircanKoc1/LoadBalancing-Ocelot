using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();




app.UseHttpsRedirection();

app.MapGet("/", () => "ocelot");


await app.UseOcelot();
app.Run();

