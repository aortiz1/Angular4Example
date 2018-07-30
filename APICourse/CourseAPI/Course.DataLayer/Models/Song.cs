using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class Song
    {
        public Song()
        {
            AlbumSong = new HashSet<AlbumSong>();
            PlayListSong = new HashSet<PlayListSong>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? AlbumId { get; set; }
        public int? Length { get; set; }

        public ICollection<AlbumSong> AlbumSong { get; set; }
        public ICollection<PlayListSong> PlayListSong { get; set; }
    }
}
