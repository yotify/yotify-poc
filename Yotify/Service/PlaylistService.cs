using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data.Api;
using Yotify.Data.Model.Playlist;

namespace Yotify.Service;

public class PlaylistService
{
    HttpClient httpClient;

    YoutubeApi youtubeApi;

    public PlaylistService()
    {
        httpClient = new HttpClient();
        youtubeApi = new YoutubeApi();
    }

    List<IPlaylist> playlists = new();

    public async Task<List<IPlaylist>> GetPlaylists()
    {
        if (playlists?.Count > 0)
        {
            return playlists;
        }

        playlists = await this.youtubeApi.GetPlaylistsAsync();

        return playlists;
    }
}
