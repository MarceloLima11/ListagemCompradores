using ListagemCompradores.Context;
using ListagemCompradores.Repository;
using ListagemCompradores.Repository.Interface;
using ListagemCompradores.Services;
using ListagemCompradores.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var mySqlConnectionStr = builder.Configuration.GetConnectionString("ListagemConnection");

builder.Services.AddDbContext<ListagemDbContext>(x =>
{
    x.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
});

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<IClienteService, ClienteService>();

builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

var app = builder.Build();

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

app.UseSession();

app.Run();
