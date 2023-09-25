using Microsoft.EntityFrameworkCore;
using Task_Manager.Domain;
using Task_Manager.Domain.Interfaces;
using Task_Manager.Repository;
using Task_Manager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var Configuration = builder.Configuration;
var connectionString = builder.Configuration
                              .GetConnectionString("DefaultString") ??
                              throw new InvalidOperationException("Connection string not found.");

builder.Services.AddDbContext<AppDbContext>(
        options => options.UseSqlServer(connectionString));

//configure services
builder.Services.AddScoped<IProviderDbContext, ProviderDbContext>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITaskService, TaskService>();



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
