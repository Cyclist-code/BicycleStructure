using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using BicycleStructure.Views;
using BicycleStructure.Models;
using System.Collections.ObjectModel;

namespace BicycleStructure.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Bicycle Structure";
            OpenAboutPageCommand = new Command(OpenPage);

            _bicycleStructures = new ObservableCollection<BicycleStructureModel>
            {
                new BicycleStructureModel { Title = "Bicycle Structure", Description = "Brief information for beginners", ImagePath = "bike.jpg" },
                new BicycleStructureModel { Title="Frame", Description="Frame material: aluminum, steel, titanium and carbon.", ImagePath="frame.jpg" },
                new BicycleStructureModel { Title="Fork", Description="Main types: rigid and shock-absorbing.", ImagePath="fork.jpg" },
                new BicycleStructureModel { Title="Wheels", Description="Components of the wheel: tire, rim, nipple. camera, bushing and spokes.", ImagePath="wheels.jpg" },
                new BicycleStructureModel { Title="Brakes", Description="Types of brakes: rim brakes and disc brakes.", ImagePath="brakes.jpg" },
                new BicycleStructureModel { Title="Transmission", Description="Transmission components: connecting rods, carriage, cassette, chain, switches and shifters.", ImagePath="transmission.jpg" }
            };
        }

        #region ObservableCollection BicycleStructures       
        private ObservableCollection<BicycleStructureModel> _bicycleStructures;

        public ObservableCollection<BicycleStructureModel> BicycleStructures
        {
            get { return _bicycleStructures; }
            set
            {
                if (_bicycleStructures != value)
                    _bicycleStructures = value;
                SetProperty(ref _bicycleStructures, value);
            }
        }
        #endregion

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
