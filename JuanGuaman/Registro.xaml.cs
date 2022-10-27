using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanGuaman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();
            lblusuario.Text = "El usuario conectado es: " + usuario;
            
        }
        double capital=3000;
        double interes=0.05;
        double tiempo = 5;
        double var1;
        double calcular=0;

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            var1 = Convert.ToDouble(txtMonto.Text);
            
            if (var1 >= 3000)
            {
                DisplayAlert("Mensaje de Alerta", "El monto inicial debe ser menor a 3000 y mayor a 0", "Cerrar");
            }
        }

        private void btnPagos_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            calcular = ((capital - var1) / tiempo) + (capital*interes)/tiempo;
            DisplayAlert("Mensaje de Alerta", "Tu nombre es: \n" + nombre + "\nCuota a pagar \n" + calcular, "Cerrar");
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            string tUsuario = txtNombre.Text;
            double tMonto = Convert.ToDouble(txtMonto.Text);

            //string tNmnreo = txtUsuario.Text;
            DisplayAlert("Alerta", "Informacion Guardada", "Cerrar");
                await Navigation.PushAsync(new Resumen(lblusuario.Text, txtNombre.Text, tMonto));
            
        }
    }
}