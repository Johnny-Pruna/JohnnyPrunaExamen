using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JohnnyPrunaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotal.Text = total;
        }

        private void btnAcerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Realizado por ", "Johnny Santiago Pruna Pruna", "ACEPTAR");
        }
    }
}