using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoremaPitagorasApp.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace TeoremaPitagorasApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hipotenusa : ContentPage
    {
        public Hipotenusa()
        {
            InitializeComponent();
            BindingContext = new MVHipotenusa(Navigation);
        }

        private void ButtonImage_Pressed(object sender, EventArgs e)
        {
            ButtonImage.Source = "HuellaActiva.png";
            try
            {
                Vibration.Vibrate(10);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ButtonImage_Released(object sender, EventArgs e)
        {
            ButtonImage.Source = "Huella.png";
        }
    }
}