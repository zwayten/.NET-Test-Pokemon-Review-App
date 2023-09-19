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
builder.Services.AddDbContext<PokemonDbContext>(options =>
    options.UseSqlServer("Data Source=POPSEY;Initial Catalog=pokemonnn;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
builder.Services.AddControllers();

//Pokemon Repo and service Injection
builder.Services.AddScoped<IPokemonRepository, PokemonRepositoryImpl>();
builder.Services.AddScoped<IPokemonService, PokemonServiceImpl>();


// Category repo and service injection
builder.Services.AddScoped<ICategoryRepository, CategoryRepositoryImpl>();
builder.Services.AddScoped<ICategoryService, CategoryServiceImpl>();

// Review repo and service injection
builder.Services.AddScoped<IReviewRepository, ReviewRepositoryImpl>();
builder.Services.AddScoped<IReviewService, ReviewServiceImpl>();

// Owner repo and service Injection
builder.Services.AddScoped<IOwnerRepository, OwnerRepositoryImpl>();
builder.Services.AddScoped<IOwnerService, OwnerServiceImpl>();

// Country repo and service Injection
builder.Services.AddScoped<ICountryRepository, CountryRepositoryImpl>();
builder.Services.AddScoped<ICountryService, CountryServiceImpl>();

builder.Services.AddScoped<IReviewerRepository, ReviewerRepositoryImpl>();
builder.Services.AddScoped<IReviewerService, ReviewerServiceImpl>();




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
