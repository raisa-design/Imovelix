using Imovelix.Api;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigurationService(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);
app.Run();