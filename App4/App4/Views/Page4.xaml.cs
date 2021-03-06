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
    public partial class Page4 : ContentPage
    {
        public Page4()
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
        private async void Hediyedgko(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hediyedgko());
        }
        private async void Sevgili(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sevgili());
        }
        private async void Yeniis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Yeniis());
        }
        private async void Icımdengeldi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Icımdengeldi());
        }
        private async void Yenibebek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Yenibebek());
        }
    }
}