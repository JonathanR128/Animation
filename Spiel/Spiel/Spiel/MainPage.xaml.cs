using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Spiel
{
    public partial class MainPage : ContentPage
    {
        public MainPage(int value)
        {
            InitializeComponent();       
            
            if (value == 1)
            {
                NeueSeite();
            }           
            
        }

        public int a { get; set; }


        public async Task NeueSeite()
        {
            await Task.Delay(10);
            App.Current.MainPage = new RundeEins();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new RundeEins();
        }

    }
}
