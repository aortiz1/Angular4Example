using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class AlbumArtist
    {
        public Guid Id { get; set; }
        public Guid? AlbumId { get; set; }
        public Guid? ArtistBandId { get; set; }

        public Album Album { get; set; }
        public ArtistBand ArtistBand { get; set; }
    }
}
