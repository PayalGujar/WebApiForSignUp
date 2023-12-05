using WebApiForSignUp.Data;
using WebApiForSignUp.Repositories;
using WebApiForSignUp.Services;
using Microsoft.OpenApi.Models;
using Dapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddSingleton<ApplicationDbContext>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
});

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c=>c.SwaggerEndpoint("/swagger/v1/swagger.json","webApiSignUp v1"));

app.Run();
