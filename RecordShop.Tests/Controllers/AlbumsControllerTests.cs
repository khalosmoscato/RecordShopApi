namespace RecordShop.Tests.Controllers;

public class AlbumsControllerTests
{
    private readonly Mock<IAlbumService> _mockService;
    private readonly AlbumsController _controller;

    public AlbumsControllerTests()
    {
        _mockService = new Mock<IAlbumService>();
        _controller = new AlbumsController(_mockService.Object);
    }

    [Fact]
    public async Task GetAllAlbums_ReturnsOkResult_WithListOfAlbums()
    {
        // Arrange
        var mockAlbums = new List<Album>
        {
            new Album { Id = 1, Title = "Blue Train", Artist = "John Coltrane" },
            new Album { Id = 2, Title = "Kind of Blue", Artist = "Miles Davis" }
        };

        _mockService
            .Setup(s => s.GetAllAlbumsAsync())
            .ReturnsAsync(mockAlbums);

        // Act
        var result = await _controller.GetAllAlbums();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedAlbums = Assert.IsAssignableFrom<IEnumerable<Album>>(okResult.Value).ToList();

        Assert.Equal(2, returnedAlbums.Count);
        Assert.Equal("Blue Train", returnedAlbums[0].Title);
    }
}
