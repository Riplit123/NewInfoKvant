namespace NewInfoKvant;

public partial class Kvantums : ContentPage
{
	public Kvantums()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new It());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new bio());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
     //   Navigation.PushModalAsync(new vr());
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new nano());
    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {
     //   Navigation.PushModalAsync(new promrobo());
    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new hitek());
    }

    private void Button_Clicked_7(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new media());
    }

    private void Button_Clicked_8(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new kvantshah());
    }

    private void Button_Clicked_9(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new engl());
    }

    private void Button_Clicked_10(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new math());
    }
}