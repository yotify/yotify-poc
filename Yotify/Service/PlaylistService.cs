using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data.Model.Playlist;

namespace Yotify.Service;

public class PlaylistService
{
    HttpClient httpClient;

    public PlaylistService()
    {
        httpClient = new HttpClient();
    }

    List<IPlaylist> playlists = new();

    public async Task<List<IPlaylist>> GetPlaylists()
    {
        if (playlists?.Count > 0)
        {
            return playlists;
        }

        var playlist1 = new YoutubePlaylist();
        playlist1.Name = "Playlist 1";
        playlist1.PlaylistURL = "test_https://www.test.com/playlists/1";
        playlists.Add(playlist1);

        var playlist2 = new YoutubePlaylist();
        playlist2.Name = "Playlist 2";
        playlist2.PlaylistURL = "test_https://www.test.com/playlists/2";
        playlists.Add(playlist2);

        var playlist3 = new YoutubePlaylist();
        playlist3.Name = "Playlist 3";
        playlist3.PlaylistURL = "test_https://www.test.com/playlists/3";
        playlists.Add(playlist3);

        return playlists;
    }
}
