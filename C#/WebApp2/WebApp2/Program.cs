﻿using Microsoft.AspNetCore.Mvc;
using WebApp2.Controller.Services;
using WebApp2.Controllers;

var builder = WebApplication.CreateBuilder(args);
//builder.Logging.AddConfiguration();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddSingleton<LocationService>();


builder.Services.AddScoped<LocationService>(); // Added dependency 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // more magic shit
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

