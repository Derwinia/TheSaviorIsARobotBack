using Microsoft.EntityFrameworkCore;
using TheSaviorIsARobotAPI.Data;
using TheSaviorIsARobotAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<WorldService>();

builder.Services.AddControllers();
builder.Services.AddDbContext<TheSaviorIsARobotContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("CNX")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(builder =>
{
    builder.AddDefaultPolicy(o =>
    {
        o.AllowAnyOrigin();
        o.AllowAnyHeader();
        o.AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
