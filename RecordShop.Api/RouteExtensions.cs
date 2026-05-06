namespace RecordShop.Api;

internal static class RouteExtensions
{
    public static void MapAlbumRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/albums");

        group.MapGet("/", async (IAlbumService albumService) =>
        {
            var albums = await albumService.GetAllAlbumsAsync().ConfigureAwait(false);
            return Results.Ok(albums);
        });
    }
}