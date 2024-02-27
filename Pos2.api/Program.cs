using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pos2.api.profile;
using Pos2.services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PosDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-61SR99M;Database=pos4;Trusted_Connection=True;TrustServerCertificate=True");
});

builder.Services.AddScoped<ICategoryRepestory, CategoryRepestory>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
