
using CommunityToolkit.Maui.Views;

namespace NewInfoKvant;

public partial class AppKvantPage : ContentPage
{
	public AppKvantPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new TestPage(true));
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Voprosyiotveti());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppKvantumsPage());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Sotrudniki());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Programms());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
       this.ShowPopup(new qrcodes());
    }
}