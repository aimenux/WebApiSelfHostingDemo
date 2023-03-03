var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("api", () => "Self hosted api is running");
app.Run();