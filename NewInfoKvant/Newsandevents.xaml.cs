using System.Collections.ObjectModel;
using System.Timers;
using System.Linq;
using System.Threading;
using Microsoft.Maui.Controls;
using Timer = System.Timers.Timer;
namespace NewInfoKvant;

public partial class Newsandevents : ContentPage
{
    public ObservableCollection<CarouselItem> Items { get; set; }
    public CarouselItem CurrentItem { get; set; }
    public class CarouselItem
    {
        public string ImageSource { get; set; }
        public string Title { get; set; }
    }

    
    private Timer _timer;
    private bool _timerEnabled = false;
    public Newsandevents(bool startTimer = false)
    {
        InitializeComponent();

        Items = new ObservableCollection<CarouselItem>
            {
                new CarouselItem { ImageSource = "firstnews.png", Title = "—тань участником грандиозного событи€!" },
                new CarouselItem { ImageSource = "secondnews.png", Title = "¬есенние каникулы по кванториански!" },
                new CarouselItem { ImageSource = "ikar.png", Title = "" }
            };
        BindingContext = this;
        InitializeTimer();
        if (startTimer)
        {
            _timerEnabled = true;
            _timer.Start();
        }
    }

    

    private void InitializeTimer()
    {
        _timer = new System.Timers.Timer(3500); //5000 миллисекунд = 5 секунд
        _timer.Elapsed += OnTimerElapsed;
        _timer.AutoReset = true;
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        if (!_timerEnabled) return;
     
        Device.InvokeOnMainThreadAsync(() =>
        {
            if (carouselView.Position < Items.Count - 1)
            {
                carouselView.Position++;
            }
            else
            {
                carouselView.Position = 0;
            }
        });
    }

    private void autoScrollButton_Clicked(object sender, EventArgs e)
    {
        _timerEnabled = !_timerEnabled;
        if (_timerEnabled)
        {
            _timer.Start();
        }
        else
        {
            _timer.Stop();
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushModalAsync(new New1());
    }

    private  async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Meropr());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
      //  await Navigation.PushModalAsync(new Sorevn());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Excurs());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
      //  await Navigation.PushModalAsync(new Voprosyiotveti());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Kvantorium());
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
       
    }
}