using Microsoft.EntityFrameworkCore;
using VideoManager.Repository;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
{
    var service = builder.Services;
    var configuration = builder.Configuration;
    service.AddDbContext<AppDbContext>(
        option => option.UseSqlServer(configuration.GetSection("ConnectionStrings").GetSection("Data").Value));
}

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
