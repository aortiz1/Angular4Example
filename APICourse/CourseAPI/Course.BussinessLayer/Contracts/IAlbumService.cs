using Course.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Course.BussinessLayer.Contracts
{
    public interface IAlbumService
    {
       Task<List<Album>> GetAllAlbums();
    }
}
