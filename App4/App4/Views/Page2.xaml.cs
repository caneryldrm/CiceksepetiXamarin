using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }



        private async void Button_clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void Button_clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void Button_clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void Button_clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        private async void Button_clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        private async void Ceptelefonuornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ceptelefonuornek());
        }
        private async void Kucukornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kucukornek());
        }
        private async void Bilgisayarornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bilgisayarornek());
        }
        private async void Televizyonornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Televizyonornek());
        }
        private async void Kameraornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kameraornek());
        }
    }
}