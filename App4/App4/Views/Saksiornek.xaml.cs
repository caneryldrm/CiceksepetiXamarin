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
    public partial class Saksiornek : ContentPage
    {
        public Saksiornek()
        {
            InitializeComponent();
        }
        private async void Beyazsaksi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Beyazsaksi());
        }
    }
}