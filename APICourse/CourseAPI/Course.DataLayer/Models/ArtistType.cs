using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class ArtistType
    {
        public ArtistType()
        {
            ArtistBand = new HashSet<ArtistBand>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? TypeArtistId { get; set; }

        public ICollection<ArtistBand> ArtistBand { get; set; }
    }
}
