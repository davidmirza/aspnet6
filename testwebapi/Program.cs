using Microsoft.EntityFrameworkCore;
using testwebapi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ContactCtx>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ContactDB")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
