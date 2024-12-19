using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserFavorite
    {
        public int UserId { get; set; }
        public int BandId { get; set; }
        public int ReleaseId { get; set; }
        public int SongId { get; set; }
        public string? Review { get; set; }

        public virtual BandList Band { get; set; } = null!;
        public virtual ReleaseList Release { get; set; } = null!;
        public virtual SongList Song { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
