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

            var totalPropina = ((total * propina)/100);
            var totalCuenta = total + totalPropina;

            txtPropina.Detail = (totalPropina).ToString("C");
            txtTotal.Detail = (totalCuenta).ToString("C");
            txtPropinaPersona.Detail = (totalPropina / numpersonas).ToString("C");
            txtTotalPropina.Detail = (totalCuenta / numpersonas).ToString("C");            
        }
    }
}
