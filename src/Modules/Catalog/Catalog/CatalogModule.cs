namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Add Services to the Container
        // services
        //     .AddApplicationServices()
        //     .AddInfrastructureServices(configuration)
        //     .AddApiServices(configuration);
        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // Configure the Http request pipeline.
        // app
        //     .UseApplicationService()
        //     .UseInfrastructureServices()
        //     .UseApiServices();
        return app;
    }
}