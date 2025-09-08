using Microsoft.EntityFrameworkCore;
using InvoiceApi.Repository;
using InvoiceApi;

using InvoiceApi.DataAccess.DataBase;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<AppDBContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("InvoiceConnection")));

        builder.Services.AddControllers();


        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddScoped<IRepositoryInvoice, InvoiceRepo>();
        builder.Services.AddScoped<IRepositoryInvoiceItem, InvoiceItemRepo>();


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
        app.UseMiddleware<ExceptionMiddleWare>();

        app.UseAuthorization();

        app.MapControllers();



        app.Run();
    }
}