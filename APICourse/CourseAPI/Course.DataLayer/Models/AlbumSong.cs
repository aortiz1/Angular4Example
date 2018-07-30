using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class AlbumSong
    {
        public Guid Id { get; set; }
        public Guid? AlbumId { get; set; }
        public Guid? SongId { get; set; }
        public string Image { get; set; }

        public Album Album { get; set; }
        public Song Song { get; set; }
    }
}
