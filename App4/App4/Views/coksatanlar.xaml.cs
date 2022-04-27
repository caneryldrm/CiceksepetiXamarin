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
    public partial class coksatanlar : ContentPage
    {
        public coksatanlar()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SevgiliHediyesiFavori());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TakiSetiFavori());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new YeniIsHediyesiFavori());
        }
    }
}