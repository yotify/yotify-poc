using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotify.Data;
using Yotify.Data.Model.Playlist;
using Yotify.Service;

namespace Yotify.ViewModel;

public partial class PlaylistOverviewViewModel : BaseViewModel
{
    PlaylistService playlistService;

    public ObservableCollection<IPlaylist> Playlists { get; } = new();

    public PlaylistOverviewViewModel(PlaylistService playlistService)
    {
        Title = "PlaylistOverview";
        this.playlistService = playlistService;
    }

    [RelayCommand]
    async Task GetPlaylistsAsync()
    {
        if (IsBusy)
            return;

        IsBusy = true;

        var playlists = new List<IPlaylist>();

        try
        {
            playlists = await playlistService.GetPlaylists();
        } catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            await Shell.Current.DisplayAlert("Error!", "Unable to fetch playlists", "Ok");
        }

        if (playlists.Count != 0)
            Playlists.Clear();

        IsBusy = false;
    }
}
