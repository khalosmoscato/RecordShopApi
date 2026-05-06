namespace RecordShop.Api.Services;

internal interface IAlbumService
{
    Task<IEnumerable<Album>> GetAllAlbumsAsync();
}