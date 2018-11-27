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
        public MainPage()
        {
            InitializeComponent();          

       
        }






        public void Button_Clicked(object sender, EventArgs e)
        {

           // App.Current.MainPage = new RundeEins();
        }
        public int a { get; set; }
    }
}
