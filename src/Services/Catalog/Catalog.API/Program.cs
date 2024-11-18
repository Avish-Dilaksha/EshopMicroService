var builder = WebApplication.CreateBuilder(args);

// Add SErvices to the container
var app = builder.Build();

// Configure the HTTP request pipeline

app.Run();
