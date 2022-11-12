using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data.Model.Playlist;
using Yotify.Storage;

namespace Yotify.Data.Api;

public sealed class YoutubeApi : IApi
{
    private HttpClient client = null;

    public async Task<List<IPlaylist>> GetPlaylistsAsync()
    {
        var playlists = new List<IPlaylist>();

        var playlist1 = new YoutubePlaylist();
        playlist1.Name = "Playlist";
        playlist1.PlaylistURL = "test_https://www.test.com/playlists/1";
        playlists.Add(playlist1);
        playlists.Add(playlist1);
        playlists.Add(playlist1);
        playlists.Add(playlist1);
        playlists.Add(playlist1);
        playlists.Add(playlist1);

        var response = await GetClient().GetStringAsync("search");

        Debug.WriteLine(response);

        return playlists;
    }

    private HttpClient GetClient()
    {
        if (this.client != null)
        {
            return this.client;
        }

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://youtube.googleapis.com/youtube/v3/");
        client.Timeout = new TimeSpan(0, 0, 0, 5);

        this.client = client;

        return client;
    }
}
