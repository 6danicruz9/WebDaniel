using Microsoft.EntityFrameworkCore;
using WebBuilderAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Configuración de la base de datos (SQLite)
builder.Services.AddDbContext<BuilderDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=builder.db"));

// 2. Soporte para controladores (donde crearemos las rutas de la API)
builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// 3. Mapear los controladores
app.MapControllers();

app.Run();