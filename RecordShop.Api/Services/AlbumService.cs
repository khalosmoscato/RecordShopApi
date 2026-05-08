namespace RecordShop.Api.Services;

internal class AlbumService(IAlbumRepository repository) : IAlbumService
{
    public async Task<IEnumerable<Album>> GetAllAlbumsAsync()
    {
        return await repository.GetAllAlbumsAsync().ConfigureAwait(false);
    }

    public async Task<Album?> GetAlbumByIdAsync(int id)
    {
        return await repository.GetAlbumByIdAsync(id).ConfigureAwait(false);
    }
}
