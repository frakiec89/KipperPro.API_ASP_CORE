using KipperPro.API_ASP_CORE.DB;
using KipperPro.API_ASP_CORE.DB.Contexts;
using KipperPro.API_ASP_CORE.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Validation>();
builder.Services.AddScoped<UsersService>();
builder.Services.AddDbContext<MsContext>();
builder.Configuration.AddJsonFile("appsettings.json");

var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
