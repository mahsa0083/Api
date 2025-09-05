using InvoiceApi.Modal.DataBase;
using Microsoft.EntityFrameworkCore;
using InvoiceApi.Repository;
using AutoMapper;
using System;
using FluentValidation;
using InvoiceApi.DTOs.Invoice;

using FluentValidation.AspNetCore;
using InvoiceApi.Modal.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<InvoiceDataBase>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("InvoiceConnection")));

        builder.Services.AddControllers();


        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddScoped<IRepositoryInvoice, RepoInvoiceServices>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
    }
}