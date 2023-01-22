using FactorialService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello! The factorial of 5 = "+FactChecker.FactorialFinder(5));


app.Run();
