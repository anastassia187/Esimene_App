﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Esimene_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry_page : ContentPage
    {
        Editor ed;
        Button btn;
        public Entry_page()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.Azure,
                TextColor = Color.Coral
            };


            btn = new Button
            {
                Text = "Tagasi"
            };



            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { ed, btn },
                BackgroundColor = Color.Aquamarine
            };
            Content = st;
            btn.Clicked += Btn_Clicked;



        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
