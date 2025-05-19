namespace NewInfoKvant;

public partial class AppItPage : ContentPage
{
	public AppItPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}