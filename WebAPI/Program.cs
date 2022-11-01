using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Businness.Abstract;
using Businness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using ServiceStack;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Services.AddControllersWithViews();
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<Service>().As<IService>());

var app = builder.Build();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();


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

