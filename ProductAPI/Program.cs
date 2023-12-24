using ProductApplication.Services;
using ProductDomain.Interfaces.Repositories;
using ProductDomain.Interfaces.Services;
using ProductInfrastructure.Data;
using ProductInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



/*
var connectionString = "mongodb://localhost:27017"; // Replace with your MongoDB connection string
var databaseName = "YourDatabaseName";

var client = new MongoClient(connectionString);
var database = client.GetDatabase(databaseName);

builder.Services.AddSingleton<IMongoDatabase>(database);
*/

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var dbConnection = configuration.GetConnectionString("SQL_CONNECTION");

// Configure DbContext
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(dbConnection));






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
