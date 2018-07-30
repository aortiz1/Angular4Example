using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class ArtistBand
    {
        public ArtistBand()
        {
            AlbumArtist = new HashSet<AlbumArtist>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bio { get; set; }
        public Guid? ArtistTypeId { get; set; }

        public ArtistType ArtistType { get; set; }
        public ICollection<AlbumArtist> AlbumArtist { get; set; }
    }
}
