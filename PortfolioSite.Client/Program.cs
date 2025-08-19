using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfiloSite.Contacts.Project;
using PortfolioSite.Contacts.About;
using PortfolioSite.Contacts.Experience;
using PortfolioSite.Contacts.Technology;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddTransient<IAboutAppService, AboutAppService>();
builder.Services.AddTransient<IProjectAppService, ProjectAppService>();
builder.Services.AddTransient<ITechAppService, TechAppService>();
builder.Services.AddTransient<IExperienceAppService, ExperienceAppService>();
await builder.Build().RunAsync();
