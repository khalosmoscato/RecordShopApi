namespace RecordShop.Api.Models;

internal class Album
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Artist { get; set; }

    public string? Genre { get; set; }

    public int ReleaseYear { get; set; }

    public int StockQuantity { get; set; }
}
