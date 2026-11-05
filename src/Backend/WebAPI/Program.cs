using Microsoft.EntityFrameworkCore;
using PortalTransparencia.Application.Interfaces;
using PortalTransparencia.Infrastructure.Persistence;
using PortalTransparencia.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar SQLite con EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// 1. Agregar controladores y Swagger / OpenAPI
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
 

// Configuración de CORS para Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 3. Registrar los servicios y repositorios de Clean Architecture
// Usamos AddSingleton temporalmente mientras el repositorio mantenga la memoria estática;
// al migrar a EF Core con DbContext cambiaremos a AddScoped.
builder.Services.AddSingleton<IPqrsdfRepository, PqrsdfRepository>();


// Elimina o comenta esta línea:
// builder.Services.AddOpenApi();

var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     // Elimina o comenta esta línea:
//     // app.MapOpenApi();
// }

// Aplicar migraciones automáticas al iniciar (ideal para entornos cloud gratuitos)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureCreated(); // Crea el archivo SQLite y tablas si no existen
}

app.UseHttpsRedirection();

// Aplicar política CORS
app.UseCors("AllowAngular");

app.UseAuthorization();
app.MapControllers();

app.Run();