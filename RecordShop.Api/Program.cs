var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<RecordShopContext>(options =>
    options.UseInMemoryDatabase("RecordShop")
);

builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.Run();
