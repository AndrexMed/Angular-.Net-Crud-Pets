using Backend.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuracion Para DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
.EnableSensitiveDataLogging());

//Configuracion para solicitudes del cliente. (Cors)
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                                    builder => builder.AllowAnyOrigin()
                                                      .AllowAnyHeader()
                                                      .AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Autorizacion de solicitudes del cliente
app.UseCors("AllowWebApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
