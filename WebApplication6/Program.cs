using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TrainerContext>(options => options.UseInMemoryDatabase("Trainers"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("trainers", (int id ,TrainerContext d )=>d.Trainers.FindAsync(id));

//app.MapDelete("/delete",(int id,TrainerContext d)=>d.Trainers.FindAsync(id));

app.MapPost("/trainers", async (Trainer e, TrainerContext d) =>
{
    d.Trainers.Add(e);
    await d.SaveChangesAsync();
});

app.MapDelete("/Trainer/{id}", async (int id, TrainerContext pc) =>
{
    if (await pc.Trainers.FindAsync(id) is Trainer p)
    {
        pc.Trainers.Remove(p);
        await pc.SaveChangesAsync();
        return Results.Ok(p);
    }
    return Results.NotFound();
});


app.Run();


app.UseHttpsRedirection();

class Trainer
{
    public int id { get; set; }
    public string name { get; set; }

}

class TrainerContext : DbContext
{
    public TrainerContext(DbContextOptions<TrainerContext> options) : base(options)
    {

    }
    public DbSet<Trainer> Trainers { get;set; }
}