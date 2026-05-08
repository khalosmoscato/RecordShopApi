namespace RecordShop.Api.Services;

internal interface IAlbumService
{
    Task<IEnumerable<Album>> GetAllAlbumsAsync();
    Task<Album?> GetAlbumByIdAsync(int id);
}
