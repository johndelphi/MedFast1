using MedFast.Data;
using MedFas1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;
using MedFast1.Repository;
using Microsoft.AspNetCore.Identity;
using MedFast1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ShopContext>(opt =>
 opt.UseSqlServer(builder.Configuration.GetConnectionString( "ShopsDb")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
 .AddEntityFrameworkStores<ShopContext>()
 .AddDefaultTokenProviders();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "MedFast1", Version = "v1" });
});
builder.Services.AddTransient<IShopRepository, ShopRepository>();
builder.Services.AddTransient<IMedicineRepository, MedicineRepository>();
builder.Services.AddTransient<IAccountRepostory, AccountRepository>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
   app.UseSwagger();
   app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MedFast1 v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
