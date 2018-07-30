using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class PlayListSong
    {
        public Guid Id { get; set; }
        public DateTime? Added { get; set; }
        public Guid? SongId { get; set; }
        public Guid? PlayListId { get; set; }

        public PlayList PlayList { get; set; }
        public Song Song { get; set; }
    }
}
