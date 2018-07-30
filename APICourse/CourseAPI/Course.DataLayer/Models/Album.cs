using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class Album
    {
        public Album()
        {
            AlbumArtist = new HashSet<AlbumArtist>();
            AlbumSong = new HashSet<AlbumSong>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? ReleaseYear { get; set; }
        public string Company { get; set; }
        public string Producer { get; set; }

        public ICollection<AlbumArtist> AlbumArtist { get; set; }
        public ICollection<AlbumSong> AlbumSong { get; set; }
    }
}
