using Microsoft.EntityFrameworkCore;
using ClienteApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), 
    new MySqlServerVersion(new Version(8, 0, 25))));

builder.Services.AddControllers();
var app = builder.Build();

// Configurar la canalización de solicitudes HTTP.
app.UseAuthorization();
app.MapControllers();
app.Run();
