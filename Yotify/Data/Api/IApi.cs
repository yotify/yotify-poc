using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data.Model.Playlist;

namespace Yotify.Data.Api;

public interface IApi
{
    public Task<List<IPlaylist>> GetPlaylistsAsync();
}
