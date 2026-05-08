using Microsoft.EntityFrameworkCore;
using RecordShop.Api.Data;

namespace RecordShop.Api.Repositories;

internal class AlbumRepository(RecordShopContext context) : IAlbumRepository
{
    public async Task<IEnumerable<Album>> GetAllAlbumsAsync()
    {
        return await context.Albums.ToListAsync().ConfigureAwait(false);
    }

    public async Task<Album?> GetAlbumByIdAsync(int id)
    {
        return await context.Albums
            .FirstOrDefaultAsync(a => a.Id == id)
            .ConfigureAwait(false);
    }
}
