using FlipCoin.ViewModels;

namespace FlipCoin.Views;

public partial class FlipCoinView : ContentPage
{
	public FlipCoinView()
	{
		InitializeComponent();
        BindingContext = new FlipCoinViewModel();
    }
}