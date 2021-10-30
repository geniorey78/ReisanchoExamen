using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReisanchoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mostrar : ContentPage
    {


        public mostrar(string user, string name, string pago, string monto)
        {
            InitializeComponent();

            lblUser.Text = "Usuario conectado: " + user;
            lblname.Text = "Nombre: " + name;
            double total = (Convert.ToDouble(pago) * 3);
            double total2 = (Convert.ToDouble(monto));
            double final = total + total2;
            lbltotal.Text = "Total a pagar: " + final.ToString();


        }
    }
}