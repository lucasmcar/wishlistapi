using Microsoft.EntityFrameworkCore;
using WishListApi.Data;
using WishListApi.Repositories;
using WishListApi.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkMySql()
    .AddDbContext<WishListDbContext>(
        options => options.UseMySql(builder.Configuration.GetConnectionString("Database"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Database")))
    );

builder.Services.AddScoped<IWishList, WishListRepository>();

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
