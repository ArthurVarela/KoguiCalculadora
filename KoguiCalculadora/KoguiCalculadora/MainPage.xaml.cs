using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KoguiCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SomarBtn_Clicked(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int total;

            n1 = Convert.ToInt32(numeroUmTxt.Text);
            n2 = Convert.ToInt32(numeroDoisTxt.Text);
            total = n1 + n2;

            ResultadoTxt.Text = total.ToString();
        }
    }
}
