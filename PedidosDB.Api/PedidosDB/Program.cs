using Microsoft.EntityFrameworkCore;
using Pedidos.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configurar conexión a la base de datos de PedidosDB
builder.Services.AddDbContext<PedidosDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("PedidosConnection")
));

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