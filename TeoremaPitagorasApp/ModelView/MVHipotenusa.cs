using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace TeoremaPitagorasApp.ModelView
{
    public class MVHipotenusa: BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONSTRUCTOR
        public MVHipotenusa(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETO
        #endregion
        #region PROCESO
        public void NavigationBack()
        {
            Navigation.PopAsync();
        }
        #endregion
        #region COMANDOS
        public ICommand NavigationBackcommand => new Command(NavigationBack);
        #endregion
    }
}
