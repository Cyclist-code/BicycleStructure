using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using BicycleStructure.Views;

namespace BicycleStructure.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Bicycle Structure";
            OpenAboutPageCommand = new Command(OpenPage);
        }

        #region Commands
        public ICommand OpenAboutPageCommand { get; }
        #endregion

        #region Methods
        private void OpenPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AboutPage());
        }
        #endregion
    }
}
