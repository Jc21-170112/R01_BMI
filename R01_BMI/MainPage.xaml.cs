using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Button_Clicked(Object sender, EventArgs e)
        {
            double h = double.Parse(hight.Text);
            double w = double.Parse(wight.Text);
            double hi = h / 100;
            
             sum.Text =  (w/ (hi * hi)).ToString();
            
        }
    }
}
