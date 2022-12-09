using AutoMapper;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;
using Services.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<ApplicationContext>(x => x.UseLazyLoadingProxies().UseMySql(connection, ServerVersion.AutoDetect(connection), options =>
    options.EnableRetryOnFailure()), ServiceLifetime.Transient);

builder.Services.AddCors(o => o.AddPolicy("DevCorsPolicy", builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddControllers(options =>
{
    options.UseDateOnlyStringConverters();
})
    .AddJsonOptions(options =>
    {
        options.UseDateOnlyStringConverters();
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MapperProfile());
    cfg.AllowNullCollections = true;
}).CreateMapper());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("DevCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
