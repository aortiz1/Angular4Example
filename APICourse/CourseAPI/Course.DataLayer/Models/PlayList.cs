using System;
using System.Collections.Generic;

namespace Course.DataLayer.Models
{
    public partial class PlayList
    {
        public PlayList()
        {
            PlayListSong = new HashSet<PlayListSong>();
        }

        public Guid Id { get; set; }
        public DateTime? Created { get; set; }
        public Guid? UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public ICollection<PlayListSong> PlayListSong { get; set; }
    }
}
