using Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigurationService().ConfigurationPipeLine();

app.Run();
