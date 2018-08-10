using Course.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Course.DataLayer.Contracts
{
    public interface IAlbumRepository
    {
        Task<List<Album>> GetAllAlbums();
        Task<List<Album>> GetAllAlbumsByArtist(Guid artistId);
    }
}
