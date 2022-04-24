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
    public partial class Page1 : ContentPage
    {
        public Page1()
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

        private async void Saksiornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Saksiornek());
        }
        private async void Orkideornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Orkideornek());
        }
        private async void Laleornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Laleornek());
        }
        private async void Gulornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gulornek());
        }
        private async void Lavantaornek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lavantaornek());
        }

        }


    }
