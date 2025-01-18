using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;

var builder = WebApplication.CreateBuilder(args);

//Configurar conexion a BD
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// PRIMEROS ENDPOINTS 
app.MapGet("/saludo/{id:int}", (int id) =>
{
    //return "Bienvenido minimal api GET";
    //return Results.BadRequest("Error generado");
    return Results.Ok("El id es :  " + id);

});


app.MapPost("/saludo2", () => "Bienvenido minimal api POST");





app.UseHttpsRedirection();
app.Run();

