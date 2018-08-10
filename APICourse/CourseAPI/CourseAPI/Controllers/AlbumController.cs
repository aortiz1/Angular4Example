using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course.BussinessLayer.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course.API.Controllers
{
    [Produces("application/json")]
    //[Route("api/Album")]
    public class AlbumController : Controller
    {
        private IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }


        // GET api/values/5
        [HttpGet]
        [Route("api/[controller]/GetAllAlbumsByArtist")]
        public async Task<ActionResult> GetAllAlbumsByArtist(Guid artistId)
        {
            try
            {
                var result = await _albumService.GetAllAlbumsByArtist(artistId);
                return this.Ok(new { success = true, result = result });
            }
            catch(Exception ex)
            {
                return this.BadRequest(new { succees = false, ex.Message });
            }

        }
    }
}