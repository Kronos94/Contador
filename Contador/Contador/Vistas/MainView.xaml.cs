using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contador.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {

        public int contador = 0;

        public MainView()
        {
            InitializeComponent();


            btnAumentar.Clicked += (sender, args) =>
            {

                lblTexto.Text = String.Format("Has pulsado el boton {0} veces", ++contador);

            };
        }
    }
}