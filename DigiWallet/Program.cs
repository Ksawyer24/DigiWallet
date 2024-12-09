using DigiWallet.Data;
using DigiWallet.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DigitalDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DigitalConnectionString")));

//builder.Services.AddDbContext<DigitalAuthDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("DigitalAuthConnectionString")));


builder.Services.Configure<PaystackConfig>(
    builder.Configuration.GetSection("Paystack"));


//builder.Services.AddAutoMapper(typeof(MapperProfiles));


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
