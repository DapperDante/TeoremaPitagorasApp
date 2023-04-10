using System;
using System.Collections.Generic;
using System.Text;
using TeoremaPitagorasApp.ModelView;
using Xamarin.Forms;
using TeoremaPitagorasApp.View;
using System.Threading.Tasks;
using System.Windows.Input;
namespace TeoremaPitagorasApp.ModelView
{
    public class MVMenu: BaseViewModel
    {
        #region VARIABLE 
        #endregion
        #region CONSTRUCTOR
        public MVMenu(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETO
        #endregion
        #region PROCESO
        public void NavigationHipotenusa()
        {
            Navigation.PushAsync(new Hipotenusa());
        }
        public void NavigationCateto()
        {
            Navigation.PushAsync(new Cateto());
        }
        #endregion
        #region COMANDOS
        public ICommand NavigationHipotenusacommand => new Command(NavigationHipotenusa);
        public ICommand NavigationCatetocommand => new Command(NavigationCateto);
        #endregion
    }
}
