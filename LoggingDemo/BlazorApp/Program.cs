using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// HIERARCHY OF LEAST VALUE TO MOST
// YOU HAVE TO TURN THESE ON
// NEED LOG STATEMENT IN CODE
// TURNED ON BY DEFAULT BY MICROSOFT
// Critical --> absolutely has to be seen, big deal, fatal problem in application
// Error --> we caught this exception but can't do anything about it
// Warning --> problem here
// Information --> this is what happen (i.e. we performed this action)
// Debug --> for debugging purposes, give you information about what's happening in your code
// Trace --> least likely used, typicaly don't turn this on, just for debugging purposes

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
