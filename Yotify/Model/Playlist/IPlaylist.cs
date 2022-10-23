using Yotify.Model.MediaItem;

namespace Yotify.Model.Playlist
{
    internal interface IPlaylist
    {
        string Name { get; set; }

        string Description { get; set; }

        string PlaylistURL { get; set; }

        string ThumbnailURL { get; set; }

        List<IMediaItem> MediaItems { get; set; }
    }
}
