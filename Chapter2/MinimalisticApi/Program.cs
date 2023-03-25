using MinimalisticAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IHelloService, HelloService>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));

app.MapGet("/{name}", ([FromRoute] string name, IHelloService service) => service.Hello(name));// c# 10 lambda expression with attributes
app.MapGet("/", () => "Hello World!");

app.Run();
