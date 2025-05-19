using CommunityToolkit.Maui.Views;

namespace NewInfoKvant;

public partial class Excurs : ContentPage
{
	public Excurs()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
       // this.ShowPopup(new qrcodes());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
       // Navigation.PushModalAsync(new VertExcurs());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}