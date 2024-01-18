using Microsoft.EntityFrameworkCore;
using APISuporte.Data;
using APISuporte.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SuporteContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("BaseSuporte")!)
);
builder.Services.AddScoped<ChamadosService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();