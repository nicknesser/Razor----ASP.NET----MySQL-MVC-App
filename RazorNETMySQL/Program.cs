using RazorNETMySQL.Data;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


//DbContext config (data storage) commenting out for now, is this even necessary for MySQL
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString());




// Add services to the container.

//Enable CORS - manually added
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options =>
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

//Json Serializer (keep JSON Serializer as default) - manually added - install Nuget Microsoft.AspNetCore.Mvc.NewtonsoftJson
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
.AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

builder.Services.AddControllersWithViews();

var app = builder.Build();

//Enable CORS - manually added
app.UseCors(options =>
options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
