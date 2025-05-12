var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Serve index.html by default
app.UseStaticFiles();  // Allows serving files from the wwwroot folder

// Define a route for "/sobre"
app.MapGet("/sobre", async context =>
{
    // Correct file path to "wwwroot/sobre.html"
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sobre.html");
    await context.Response.SendFileAsync(filePath);
});

// Start the application
app.Run();
