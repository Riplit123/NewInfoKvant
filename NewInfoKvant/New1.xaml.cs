namespace NewInfoKvant;

public partial class New1 : ContentPage
{
    public New1()
    {
        InitializeComponent();
    }
   
    

    private async void Button_Clicked(object sender, EventArgs e)
    {
      await Navigation.PopModalAsync();
    }

   
}
