using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
// using static MauiApp26.Newsandevents;

namespace NewInfoKvant;

public partial class Sorevn : ContentPage
{
    public ObservableCollection<CarouselItem> Items { get; set; }
    public CarouselItem CurrentItem { get; set; }


   
    public class CarouselItem
    {
        public string ImageSource { get; set; }
        public string Title { get; set; }
    }
    public Sorevn()
	{
		InitializeComponent();
        Items = new ObservableCollection<CarouselItem>
            {
                new CarouselItem { ImageSource = "Sorev.jpg" },
                new CarouselItem { ImageSource = "itkv.jpg"},
                new CarouselItem { ImageSource = "mathkv.jpg"}
            };

        BindingContext = this;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new qrcodes());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}