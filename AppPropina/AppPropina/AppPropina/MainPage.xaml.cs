using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = decimal.Parse(entTotal.Text);
            var propina = decimal.Parse(entPropina.Text);
            var numpersonas = decimal.Parse(entNumPersona.Text);

            var totalPropina = total * propina;
            var totalC = total + totalPropina;

            txtPropina.Detail = (totalPropina).ToString("C");
            txtTotal.Detail = (totalC).ToString("C");
            txtPropinaPersona.Detail = (totalPropina / numpersonas).ToString("C");
            txtTotalPropina.Detail = (totalC / numpersonas).ToString("C");            
        }
    }
}
