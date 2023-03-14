var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/account", () => "Hello World!");


app.Run();
