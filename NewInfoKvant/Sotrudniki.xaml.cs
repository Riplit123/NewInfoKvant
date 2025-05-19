namespace NewInfoKvant;

public partial class Sotrudniki : ContentPage
{
	public Sotrudniki()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}