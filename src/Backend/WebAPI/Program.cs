using PortalTransparencia.Application.Interfaces;
using PortalTransparencia.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

// Aplicar política CORS
app.UseCors("AllowAngular");

app.UseAuthorization();
app.MapControllers();

app.Run();