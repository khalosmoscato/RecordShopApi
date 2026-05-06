using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
internal class AlbumsController(IAlbumService albumService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAlbums()
    {
        var albums = await albumService.GetAllAlbumsAsync().ConfigureAwait(false);
        return Ok(albums);
    }
}