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
    public partial class Page3 : ContentPage
    {
        public Page3()
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
        private async void Dgkohediye(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dgkohediye());
        }
        private async void Dgkocicek(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dgkocicek());
        }
        private async void Cikolata(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cikolata());
        }
        private async void Teraryum(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teraryum());
        }
        private async void Meyvesepeti(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meyvesepeti());
        }
    }
}