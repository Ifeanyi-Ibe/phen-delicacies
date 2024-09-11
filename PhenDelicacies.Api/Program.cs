var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
