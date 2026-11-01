var builder = WebApplication.CreateBuilder(args);

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

builder.Services.AddControllers();
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