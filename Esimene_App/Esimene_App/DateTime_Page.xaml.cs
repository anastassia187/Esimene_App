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
    public partial class DateTime_Page : ContentPage
    {
        Label lbl;
        DatePicker dp;
        TimePicker tp;
        public DateTime_Page()
        {
            lbl = new Label
            {
                Text = "Vali mingi kuupäev",
                BackgroundColor = Color.BurlyWood
            };
            dp = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-5),
                MaximumDate = DateTime.Now.AddDays(5),
                TextColor = Color.Red
            };
            dp.DateSelected += Dp_DateSelected;
            tp = new TimePicker
            {
                Time = new TimeSpan(12, 0, 0)
            };
            tp.PropertyChanged += Tp_PropertyChanged;
            AbsoluteLayout abs = new AbsoluteLayout
            {
                Children = { lbl, dp, tp }
            };
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.1, 0.2, 200, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(dp, new Rectangle(0.1, 0.5, 300, 50));
            AbsoluteLayout.SetLayoutFlags(dp, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(tp, new Rectangle(0.5, 0.7, 300, 50));
            AbsoluteLayout.SetLayoutFlags(tp, AbsoluteLayoutFlags.PositionProportional);
            Content = abs;
        }
        private async void ShowTime()
        {

            var time = (int)(tp.Time.TotalSeconds - DateTime.Now.TimeOfDay.TotalSeconds);
            while (time != 0)
            {
                await Task.Delay(1000);
                lbl.Text = time.ToString();
                time = (int)(tp.Time.TotalSeconds - DateTime.Now.TimeOfDay.TotalSeconds);
                if (time == 0)
                {
                    lbl.BackgroundColor = Color.Red;
                }
            }

        }

        private void Tp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lbl.Text = "Oli valitud aeg: " + tp.Time;
            ShowTime();
        }
        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {

            lbl.Text = "Oli valitud kuupäev: " + e.NewDate.ToString("G");
        }
    }
}