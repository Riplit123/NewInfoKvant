namespace NewInfoKvant;
public partial class Voprosyiotveti : ContentPage
{
	public Voprosyiotveti()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Newsandevents(true));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AppKvantPage());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AppMainPage());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        DisplayPromptAsync("Введите вопрос","Поле ввода","Отправить","Отмена");
    }
}