using Course.BussinessLayer.Contracts;
using Course.DataLayer.Contracts;
using Course.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Course.BussinessLayer.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<List<Album>> GetAllAlbums()
        {
            return await _albumRepository.GetAllAlbums();
        }

        public async Task<List<Album>> GetAllAlbumsByArtist(Guid artistId)
        {
            return await _albumRepository.GetAllAlbumsByArtist(artistId);
        }
    }
}
