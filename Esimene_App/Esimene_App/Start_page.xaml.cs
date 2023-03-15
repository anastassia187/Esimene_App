using Esimene_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Esimene_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class start_page : ContentPage
    {

        List<ContentPage> pages = new List<ContentPage>() {new Entry_page(),new Timer_Page(), new BoxView_Page(),
            new Valgusfoor(), new StepperSlider_Page(), new DateTime_Page(), new Frame_page(),
            new Image_page()};
        List<string> tekstid = new List<string> { "Ava Entry leht","Ava Timer leht", "Ava BoxView leht",
            "Ava Valgusfoor leht", "Ava StepperSlider leht", "Ava DateTime leht", "Ava Frame leht", "Ava Image leht"};
        public start_page()
        {
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.HotPink,
            };
            for (int i = 0; i < pages.Count; i++)
            {
                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    TextColor = Color.Black,
                    BackgroundColor = Color.LavenderBlush,
                };

                st.Children.Add(button);
                button.Clicked += Navig_funktsioon;
            }
            Content = st;
        }

        private async void Navig_funktsioon(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            await Navigation.PushAsync(pages[btn.TabIndex]);
        }

    }
}



