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
            new Album
            {
                Id = 1,
                Title = "21",
                Artist = "Adele",
            },
            new Album
            {
                Id = 2,
                Title = "Islands",
                Artist = "Ludovico Einaudi",
            },
        };

        _mockService.Setup(s => s.GetAllAlbumsAsync()).ReturnsAsync(mockAlbums);

        // Act
        var result = await _controller.GetAllAlbums();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedAlbums = Assert.IsAssignableFrom<IEnumerable<Album>>(okResult.Value).ToList();

        Assert.Equal(2, returnedAlbums.Count);
        Assert.Equal("21", returnedAlbums[0].Title);
    }

    [Fact]
    public async Task GetAlbumById_ReturnsOkResult_WhenAlbumExists()
    {
        // Arrange
        var mockAlbum = new Album { Id = 1, Title = "Loud", Artist = "Rihanna" };
        _mockService.Setup(s => s.GetAlbumByIdAsync(1))
                    .ReturnsAsync(mockAlbum);

        // Act
        var result = await _controller.GetAlbumById(1);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedAlbum = Assert.IsType<Album>(okResult.Value);
        Assert.Equal("Loud", returnedAlbum.Title);
    }

    [Fact]
    public async Task GetAlbumById_ReturnsNotFound_WhenAlbumDoesNotExist()
    {
        // Arrange
        _mockService.Setup(s => s.GetAlbumByIdAsync(It.IsAny<int>()))
                    .ReturnsAsync((Album?)null);

        // Act
        var result = await _controller.GetAlbumById(99);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}
