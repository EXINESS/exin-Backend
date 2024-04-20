
using backend.Domain.Cores.TargetAggregate;
using backend.Infrastucture;
using backend.Infrastucture.Repositories;
using backend.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<exinDBContext>(options =>
{
    var constr = builder.Configuration.GetConnectionString("exindb");

  options.UseSqlServer(constr);
});


//builder.Services.AddScoped<IAchiveSerive, AchiveService>;
//builder.Services.AddScoped<ITargetService, TargetService>;
builder.Services.AddScoped<ISubTaskService, SubTaskService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
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
