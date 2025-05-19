using CommunityToolkit.Maui.Views;

namespace NewInfoKvant;

public partial class Kvantorium : ContentPage
{
	public Kvantorium()
	{
		InitializeComponent();
	}
    public void Exit(object sender, EventArgs e)
    {
        

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      //  Navigation.PushModalAsync(new Voprosyiotveti());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Newsandevents());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
       
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
     //   this.ShowPopup(new qrcodes());
    }
}