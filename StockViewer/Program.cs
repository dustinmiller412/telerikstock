using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Telerik.Blazor.Services;
using StockViewer;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.Services.AddDbContext<YourDbContext>(options =>
//    options.UseSqlServer("Server=localhost;Database=StockViewer;Trusted_Connection=True;"));

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTelerikBlazor();

await builder.Build().RunAsync();
