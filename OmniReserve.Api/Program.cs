using OmniReserve.Infrastructure;
using OmniReserve.Application;
using Microsoft.EntityFrameworkCore;
using OmniReserve.Infrastructure.Persistence;

using OmniReserve.Infrastructure;

using OmniReserve.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Registrar infraestructura y la cadena de conexión
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();