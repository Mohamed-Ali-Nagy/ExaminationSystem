using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using ExaminationSystem;
using ExaminationSystem.Helpers;
using ExaminationSystem.Middlewares;
using ExaminationSystem.Profiles;
using Microsoft.AspNetCore.Components.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutoFacModule()));
builder.Services.AddAutoMapper(typeof(CourseProfile));
var app = builder.Build();
MappHelper.Mapper = app.Services.GetService<IMapper>();
app.UseMiddleware<GlobalErrorHandlerMiddleware>();
app.UseMiddleware<TransactionMiddleware>();
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
