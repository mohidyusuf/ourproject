using CarRental.Components;
using CarRental.Services;
using Dal;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 1. Bind MongoDB configuration from appsettings.json
builder.Services.Configure<DbRegistration>(
    builder.Configuration.GetSection("MongoDBSettings"));

// 2. Register DbRegistration for direct injection
builder.Services.AddSingleton(resolver =>
    resolver.GetRequiredService<IOptions<DbRegistration>>().Value);


// Register services

builder.Services.AddScoped<IRegistrationService, ServiceRegistration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
