namespace RecordShop.Api.Services;

internal class AlbumService(IAlbumRepository repository) : IAlbumService
{
    public async Task<IEnumerable<Album>> GetAllAlbumsAsync()
    {
        // Currently a pass-through, but this is where
        // your logic will live in Task 8-14.
        return await repository.GetAllAlbumsAsync().ConfigureAwait(false);
    }
}
