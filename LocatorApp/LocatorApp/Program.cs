using Locator.utility;
using Locator.utility.IPGeolocationServices;
using LocatorApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("ipgeolocation", client =>
{
    client.BaseAddress = new Uri("https://api.ipgeolocation.io");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});


builder.Services.AddAutoMapper(typeof(LocatorMapperProfile));

//Service lifetime
builder.Services.AddTransient<IIpGeoLocationService, IpGeoLocationService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
