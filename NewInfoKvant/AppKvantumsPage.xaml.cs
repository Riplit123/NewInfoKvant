using static Microsoft.Maui.ApplicationModel.Permissions;
using System;

namespace NewInfoKvant;

public partial class AppKvantumsPage : ContentPage
{
	public AppKvantumsPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppItPage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new bio());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new vr());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new nano());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new promrobo());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new hitek());
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
       await Navigation.PushModalAsync(new media());
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new kvantshah());
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new engl());
    }

    private async void Button_Clicked_10(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new math());
    }
}