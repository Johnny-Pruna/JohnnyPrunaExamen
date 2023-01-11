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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen());
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            txtMontoInicial.Text = OperacionFin.ToString();

            if (OperacionFin >= 7 && OperacionFin <= 10)
            { // Si la condicion se cumple 

                // mostramos este mensaje
                txtVerificar.Text = ("Aprobado");
                DisplayAlert("Felicitaciones APROBADO", " Su nota final es:" + " " + OperacionFin, "cerrar");

            }
            try
            {
                double montoInicial = Convert.ToDouble(txtMontoInicial.Text);

                double valor = 4000-montoInicial/200;
                DisplayAlert("Pago mensual", valor.ToString(), "Cerrar");
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}