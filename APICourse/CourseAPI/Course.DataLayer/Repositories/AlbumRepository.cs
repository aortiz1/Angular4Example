﻿using Course.DataLayer.Contracts;
using Course.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Course.DataLayer.Repositories
{
    public class AlbumRepository: IAlbumRepository
    {
        private readonly MLContext _context;

        public AlbumRepository(MLContext context)
        {
            _context = context;
        }

        public async Task<List<Album>> GetAllAlbums()
        {
            try
            {
                var result = await _context.Album.ToListAsync();
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception("An error ocurred in database", ex);
            }
        }

        public async Task<List<Album>> GetAllAlbumsByArtist(Guid artistId)
        {
            try
            {
                var query = await (from x in _context.AlbumArtist join y in _context.Album on x.AlbumId equals y.Id where x.ArtistBandId == artistId select y).ToListAsync();
                 
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception("An error ocurred in database", ex);
            }
        }
    }
}
