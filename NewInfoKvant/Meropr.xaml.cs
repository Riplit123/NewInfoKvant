using CommunityToolkit.Maui.Views;

namespace NewInfoKvant;

public partial class Meropr : ContentPage
{
	public Meropr()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
     //   this.ShowPopup(new qrcodes());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}