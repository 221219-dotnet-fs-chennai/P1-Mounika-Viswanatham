global using Serilog;
using BusinessLogic;
using FluentAPI;
using FluentAPI.Entities;
using Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMemoryCache();
builder.Services.AddControllers().AddXmlSerializerFormatters();

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
)
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration.GetConnectionString("Trainerdatabase");
builder.Services.AddDbContext<TrainerdatabaseContext>(Options=>Options.UseSqlServer(config));
builder.Services.AddScoped<IModel<FluentAPI.Entities.TrainerDetail>, EFRepo>();
builder.Services.AddScoped<IEduRepo<FluentAPI.Entities.EducationDetail>, EducationRepo>();
builder.Services.AddScoped<ICompany<FluentAPI.Entities.CompanyDetail>, CompanyRepo>();
builder.Services.AddScoped<ISkill<FluentAPI.Entities.SkillsDetail>, SkillRepo>();
    

builder.Services.AddScoped<ILogic, Logic>();


Log.Logger = new LoggerConfiguration().WriteTo.File(@"..\logger\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true).CreateLogger();

Log.Logger.Information("Program starts");

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
