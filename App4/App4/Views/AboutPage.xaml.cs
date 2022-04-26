using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace App4.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();


            List<Kaydirmaligorsel> gorseller = new List<Kaydirmaligorsel>()
            {
                new Kaydirmaligorsel(){Title="Image 1",Url="https://i.hizliresim.com/nm0ro5a.jpg"},
                new Kaydirmaligorsel(){Title="Image 1",Url="https://i.hizliresim.com/mn73g6g.jpg"},
                new Kaydirmaligorsel(){Title="Image 1",Url="https://i.hizliresim.com/kxrjrxm.jpg"}
            };

            Carousel.ItemsSource = gorseller;

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new coksatanlar());
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new superfiyatlar());
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ozelfirsatlar());
        }

    }
}