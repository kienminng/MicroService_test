using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UserManager.Repository;

var builder = WebApplication.CreateBuilder(args);
{
    var configuration = builder.Configuration;
    var service = builder.Services;
    service.AddDbContext<AppDbContext>(
        option
            => option.UseSqlServer(configuration.GetSection("ConnectionStrings").GetSection("data").Value)
    );
}


builder.Services.AddControllers();
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
