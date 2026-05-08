namespace RecordShop.Api.Repositories;

internal interface IAlbumRepository
{
    Task<IEnumerable<Album>> GetAllAlbumsAsync();
    Task<Album?> GetAlbumByIdAsync(int id);
}
