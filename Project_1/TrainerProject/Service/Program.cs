using Bussiness;
using FluentAPI;
using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Model;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration.GetConnectionString("Trainerdbase");

builder.Services.AddDbContext<TrainerdatabaseContext>(Options => Options.UseSqlServer(config));
builder.Services.AddScoped<IRepo<FluentAPI.Entities.TrainerDetail>, EFRepo>();
builder.Services.AddScoped<IBusiness, Logic>();

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
