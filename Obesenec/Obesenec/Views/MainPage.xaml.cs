using Obesenec.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Obesenec.Model
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            
            string[] Words = { "auto", "okno", "svet", "voda", "kryt" };
            Random rnd = new Random();
            int index = rnd.Next(Words.Length);
            String s = Convert.ToString(Words[index]);
            var chars = s.ToCharArray();
            viewModel = new MainViewModel();
            BindingContext = viewModel;

            
        }
    }
}
