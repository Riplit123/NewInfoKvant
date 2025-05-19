namespace NewInfoKvant;

public partial class It : ContentPage
{
	public It()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}