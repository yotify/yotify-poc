using Yotify.ViewModel;

namespace Yotify.View;

public partial class PlaylistOverview : ContentPage
{
	public PlaylistOverview(PlaylistOverviewViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}