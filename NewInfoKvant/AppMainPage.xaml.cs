namespace NewInfoKvant;

public partial class AppMainPage : ContentPage
{
	public AppMainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppKvantPage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
      //  await Navigation.PushModalAsync(new TestPage(true));
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppVoprPage());
    }
}