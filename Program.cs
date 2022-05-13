global using WareHouseAPI.Data;
global using Microsoft.EntityFrameworkCore;
using WareHouseAPI.Interfaces;
using WareHouseAPI.Repository;
using WareHouseAPI.Services;

const string corsName = "Frontend";

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<DataContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnestion"));
//});

builder.Services.AddDbContext<DataContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o => o.AddPolicy(corsName, cors => cors.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddScoped<IWarehouseService, WarehouseService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

var app = builder.Build();

using (var context = new DataContext()) { context.Database.EnsureCreated(); } // Seed

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(corsName);

app.Run();
