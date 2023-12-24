namespace Middleware
{
    public static class HostingExtension
    {
        public static WebApplication ConfigurationService(this WebApplicationBuilder builder)
        {
            return builder.Build();
        }

        public static WebApplication ConfigurationPipeLine(this WebApplication app)
        {
            return app;
        }
    }
}
