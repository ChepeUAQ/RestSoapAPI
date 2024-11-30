using Microsoft.EntityFrameworkCore;
using Soap.Contracts;
using Soap.Infraestructure;
using Soap.Repositories;
using Soap.Services;
using SoapCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
builder.Services.AddScoped<IPiezaRepository, PiezaRepository>();
builder.Services.AddScoped<IPiezaContract, PiezaService>();


builder.Services.AddDbContext<RelationalDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();
app.UseSoapEndpoint<IPiezaContract>("/PiezaService.svc", new SoapEncoderOptions());



app.Run();