using BusinessLogic;
using FluentAPI;
using FluentAPI.Entities;
using Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration.GetConnectionString("Trainerdatabase");
builder.Services.AddDbContext<TrainerdatabaseContext>(Options=>Options.UseSqlServer(config));
builder.Services.AddScoped<IModel<FluentAPI.Entities.TrainerDetail>, EFRepo>();
builder.Services.AddScoped<ILogic, Logic>();



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
