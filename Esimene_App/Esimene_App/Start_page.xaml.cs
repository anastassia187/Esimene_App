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
        public start_page()
        {
            InitializeComponent();
            Button Entry_btn = new Button
            {
                Text = "Ava Entry leht",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };
            Button Timer_btn = new Button
            {
                Text = "Ava Timer leht",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };
            Button Box_btn = new Button
            {
                Text = "Ava BoxView leht",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };

            Button Valgusfoor_btn = new Button
            {
                Text = "Valgusfoor",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };
            Button Date_btn = new Button
            {
                Text = "Ava Date/Time leht",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };
            Button Step_btn = new Button
            {
                Text = "Stepper/Slider",
                TextColor = Color.Black,
                BackgroundColor = Color.Violet
            };


            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, Box_btn, Valgusfoor_btn, Date_btn, Step_btn },
                BackgroundColor = Color.Yellow
            };
            Content = st;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
            Valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked1;
            Date_btn.Clicked += Date_btn_Clicked;
            Step_btn.Clicked += Step_btn_Clicked;
        
        
        }
        private async void Step_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }


        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }

        private async void Valgusfoor_btn_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new Valgusfoor());
        }

 
        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }
        
        
        
    }
}
