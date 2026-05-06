using Microsoft.EntityFrameworkCore;

namespace RecordShop.Api.Data;

internal class RecordShopContext(DbContextOptions<RecordShopContext> options) : DbContext(options)
{
    public DbSet<Album> Albums => Set<Album>();
}