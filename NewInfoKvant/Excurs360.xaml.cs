namespace NewInfoKvant;

public partial class Excurs360 : ContentPage
{
	public Excurs360()
	{
		InitializeComponent();
        Loa();
    }

    private void Loa()
    {
        var htmlSource = new HtmlWebViewSource
        {
            Html = @"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <meta name='viewport' content='width=device-width, initial-scale=1'>
                        <style>
                            html, body { height: 100%; margin: 0; }
                            #panorama { width: 100%; height: 100%; }
                        </style>
                    </head>
                    <body>
                        <div id='panorama'></div>
                        <script src='https://cdnjs.cloudflare.com/ajax/libs/pannellum/2.5.6/pannellum.js'></script>
                        <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/pannellum/2.5.6/pannellum.css'/>
                        <script>
                            pannellum.viewer('panorama', {
                                'type': 'equirectangular',
                                'panorama': 'https://sun9-64.userapi.com/impg/yuSBqrSQA-f1TH66D8QgkCTyRwMB2hTFj4J_wQ/RbBSyaLrUws.jpg?size=2560x1280&quality=95&sign=cd2c763afc1950ef0a7a670fac75d884&type=album',
                                'autoLoad': true
                            });
                        </script>
                    </body>
                    </html>"
        };

        foto.Source = htmlSource;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}