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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAlbumById(int id)
    {
        var album = await albumService.GetAlbumByIdAsync(id).ConfigureAwait(false);

        if (album == null)
        {
            return NotFound();
        }

        return Ok(album);
    }
}