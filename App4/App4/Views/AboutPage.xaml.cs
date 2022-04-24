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
                new Kaydirmaligorsel(){Title="Image 1",Url="https://cdn03.ciceksepeti.com/slider/webled637862243287135387.jpg"},
                new Kaydirmaligorsel(){Title="Image 1",Url="https://cdn03.ciceksepeti.com/slider/cicekhediyeweb-44637862241864371762.jpg"},
                new Kaydirmaligorsel(){Title="Image 1",Url="https://cdn03.ciceksepeti.com/slider/web6637861275730622387.jpg"}
            };

            Carousel.ItemsSource = gorseller;

        }
    }
}