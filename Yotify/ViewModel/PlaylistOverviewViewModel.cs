using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        try
        {
            IsBusy = true;
            var playlists = await playlistService.GetPlaylists();

            if (playlists.Count != 0)
                Playlists.Clear();

            foreach(var playlist in playlists)
                Playlists.Add(playlist);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            await Shell.Current.DisplayAlert("Error!", "Unable to fetch playlists", "Ok"); // TODO: abstraction
        }
        finally
        {
            IsBusy = false;
        }
    }
}
