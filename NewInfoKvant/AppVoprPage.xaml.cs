namespace NewInfoKvant;

public partial class AppVoprPage : ContentPage
{
	public AppVoprPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppKvantPage());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
      //  await Navigation.PushModalAsync(new TestPage());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        DisplayPromptAsync("Введите вопрос", "Поле ввода", "Отправить", "Закрыть");
    }
}