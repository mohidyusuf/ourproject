
using CarRentalApp.Components;
using CarRentalApp.Services;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// 1. Bind MongoDB configuration from appsettings.json
builder.Services.Configure<DbRegistration>(
    builder.Configuration.GetSection("MongoDBSettings"));


builder.Services.AddSingleton(resolver =>
    resolver.GetRequiredService<IOptions<DbRegistration>>().Value);






// Register services

builder.Services.AddScoped<CarRentalApp.Services.IRegistrationService, ServiceRegistration>();
builder.Services.AddScoped<CarRentalApp.Services.IContactShowroomService, ContactShowroomService>();
builder.Services.AddScoped<CarRentalApp.Services.IShowroomProfileService, ShowroomProfileService>();
builder.Services.AddScoped<CarRentalApp.Services.ISocialReferencesService,SocialReferencesService >();
builder.Services.AddScoped<CarRentalApp.Services.IShowroomAddressService,ShowroomAddressService >();
builder.Services.AddScoped<CarRentalApp.Services.IAboutShowroomService,AboutShowroomService >();
builder.Services.AddScoped<CarRentalApp.Services.IBranchService,BranchService >();



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
