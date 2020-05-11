using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Obesenec
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Doprava_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Model.MainPage());
        }
        private void Jedlo_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Jedlo());
        }
        private void Oblecenie_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Oblecenie());
        }
        private void Mix_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Mix());
        }

    }
}