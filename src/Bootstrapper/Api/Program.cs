var builder=WebApplication.CreateBuilder(args);

// Add Service to the container.
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app=builder.Build();

// Configure the http request pipeline
app
    .UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();
app.Run();

app.MapControllers();