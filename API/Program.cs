using Application.Services;
using Data;
using Data.Repositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().ConfigureApiBehaviorOptions(x => { x.SuppressMapClientErrors = true; }); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Pokemon Repo and service Injection
builder.Services.AddScoped<IPokemonRepository, PokemonRepositoryImpl>();
builder.Services.AddScoped<IPokemonService, PokemonServiceImpl>();


// Review repo and service injection
builder.Services.AddScoped<IReviewRepository, ReviewRepositoryImpl>();
builder.Services.AddScoped<IReviewService, ReviewServiceImpl>();

builder.Services.AddDbContext<PokemonDbContext>(options =>
    options.UseSqlServer("Data Source=POPSEY;Initial Catalog=pokemonn;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
builder.Services.AddControllers();


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
