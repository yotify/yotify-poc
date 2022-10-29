using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data.Model.MediaItem;

namespace Yotify.Data.Model.Playlist
{
    internal class YoutubePlaylist : IPlaylist
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PlaylistURL { get; set; }
        public string ThumbnailURL { get; set; }
        public List<IMediaItem> MediaItems { get; set; }
    }
}
