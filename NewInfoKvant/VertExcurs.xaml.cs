namespace NewInfoKvant;

public partial class VertExcurs : ContentPage
{
	public VertExcurs()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Excurs360());
	}

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}
