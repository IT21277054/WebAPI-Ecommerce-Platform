// ====================================================
// File: Program.cs
// Description: ASP.NET Core application startup configuration.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application;
using Ecommerce.Infrastructure;
using Ecommerce.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();  // Registers application-level services
builder.Services.AddInfrastructureServices(builder.Configuration);  // Registers infrastructure services
builder.Services.AddPersistenceServices(builder.Configuration);  // Registers persistence services

builder.Services.AddControllers();  // Adds controllers to the service container

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();  // Enables API exploration
builder.Services.AddSwaggerGen();  // Adds Swagger generation

// Configure CORS to allow all origins, headers, and methods
builder.Services.AddCors(options =>
{
    options.AddPolicy("*", builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();  // Build the application

app.UseCors("*");  // Enable CORS

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Enable Swagger in development
    app.UseSwaggerUI();  // Enable Swagger UI
}

app.UseHttpsRedirection();  // Redirect HTTP requests to HTTPS
app.UseAuthorization();  // Enable authorization middleware

app.MapControllers();  // Map controller actions to routes

app.Run();  // Run the application
