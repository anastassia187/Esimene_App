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
    public partial class Valgusfoor : ContentPage
    {
        Label red, yellow, green;
        Frame r, y, g;
        Button on, off, night;
        public Valgusfoor()
        {
            InitializeComponent();
            red = new Label()
            {
                Text = "red",
                TextColor = Color.Gray,
                FontSize = 20
            };
            r = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = red,
                CornerRadius = 110,
                Margin = new Thickness(150, 0, 150, 0)
            };
            yellow = new Label()
            {
                Text = "yellow",
                TextColor = Color.Gray,
                FontSize = 20
            };
            y = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = yellow,
                CornerRadius = 110,
                Margin = new Thickness(150, 0, 150, 0)
            };
            green = new Label()
            {
                Text = "green",
                TextColor = Color.Gray,
                FontSize = 20
            };
            g = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = green,
                CornerRadius = 110,
                Margin = new Thickness(150, 0, 150, 0)
            };
            on = new Button()
            {
                Text = "TurnOn",
                BackgroundColor = Color.Blue,
                BorderWidth = 2,
                FontAttributes = FontAttributes.Bold
            };
            off = new Button()
            {
                Text = "TurnOff",
                BackgroundColor = Color.LightBlue,
                BorderWidth = 2,
                FontAttributes = FontAttributes.Bold
            };
            night = new Button()
            {
                Text = "NightMode",
                BackgroundColor = Color.LightGray,
                TextColor = Color.Black,
                BorderWidth = 2
            };

            on.Clicked += On_Clicked;
            off.Clicked += Off_Clicked;
            night.Clicked += Night_Clicked;


            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            r.GestureRecognizers.Add(tap);
            y.GestureRecognizers.Add(tap);
            g.GestureRecognizers.Add(tap);


            StackLayout stackLayout = new StackLayout()
            {
                Children = { r, y, g }
            };
            stackLayout.Orientation = StackOrientation.Vertical;

            StackLayout stackLayoutBtn = new StackLayout()
            {
                Children = { on, off, night }
            };
            stackLayoutBtn.Orientation = StackOrientation.Horizontal;

            StackLayout stack = new StackLayout()
            {
                Children = { stackLayout, stackLayoutBtn }
            };
            Content = stack;
        }

        private void Night_Clicked(object sender, EventArgs e)
        {
            r.BackgroundColor = Color.Gray;
            y.BackgroundColor = Color.Yellow;
            g.BackgroundColor = Color.Gray;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == r)
            {
                red.Text = "Stop!!!";
            }
            else if (fr == y)
            {
                yellow.Text = "Attention!";
            }
            else if (fr == g)
            {
                green.Text = "Go!!!!!!";
            }
        }

        private void Off_Clicked(object sender, EventArgs e)
        {
            r.BackgroundColor = Color.Gray;
            y.BackgroundColor = Color.Gray;
            g.BackgroundColor = Color.Gray;
        }

        private void On_Clicked(object sender, EventArgs e)
        {
            r.BackgroundColor = Color.Red;
            y.BackgroundColor = Color.Yellow;
            g.BackgroundColor = Color.Green;
        }
    }
}