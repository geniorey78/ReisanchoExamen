using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReisanchoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUser.Text = "Usuario conectado: " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double valor = 1800 - Convert.ToDouble(txtMonto.Text);
            double valor2 = valor / 3;
            double porc = valor2 * 0.05;
            double pagar = porc + valor2;
            txtPago.Text = pagar.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", ex.Message, "Ok");

            }
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Guardado", "Guardaro con Exito", "Ok");
            string user = lblUser.Text;
            string name = txtNombre.Text;
            string pago = txtPago.Text;
            string monto = txtMonto.Text;
            await Navigation.PushAsync(new mostrar(user, name, pago, monto));
        }
    }
}
