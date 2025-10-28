using Trabalho.Repositories;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

//add repositories 
builder.Services.AddSingleton<ICanalRepository, InMemoryCanalRepository>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services.AddSwagger();
builder.Services.AddEndPointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.MapSwagger();
    app.MapEndPointsApiExplorer();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
