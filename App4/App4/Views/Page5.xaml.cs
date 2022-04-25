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
    public partial class Page5 : ContentPage
    {
        public Page5()
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
        private async void Ayakkabı(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ayakkabı());
        }
        private async void Canta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Canta());
        }
        private async void Giyim(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Giyim());
        }
        private async void Takı(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Takı());
        }
        private async void Parfum(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Parfum());
        }
    }

}