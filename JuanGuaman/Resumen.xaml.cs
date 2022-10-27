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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String nombre, double monto)
        {
            InitializeComponent();
            lblusuario.Text = "El usuario conectado es: " + usuario;
            lblnombre.Text= "El nombre es: " + nombre;
            lblmonto.Text = "monto: " + monto;



        }
    }
}