using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BicycleStructure.ViewModels
{
    public class AboutPageViewModel : BaseViewModel
    {
        public AboutPageViewModel()
        {
            Title = "About";
            VersionApp = "0.1.042023";

            OpenGitHubCommand = new Command(async () => await Browser.OpenAsync("https://github.com/Cyclist-code/BicycleStructure"));
            OpenDocumentationCommand = new Command(async () => await Browser.OpenAsync("https://github.com/Cyclist-code/BicycleStructure/blob/master/README.md"));
            OpenIssuesCommand = new Command(async () => await Browser.OpenAsync("https://github.com/Cyclist-code/BicycleStructure/issues"));
        }

        #region Version app
        string version = string.Empty;
        public string VersionApp
        {
            get { return version; }
            set { SetProperty(ref version, value); }
        }
        #endregion

        #region Commands
        public ICommand OpenGitHubCommand { get; }
        public ICommand OpenDocumentationCommand { get;}
        public ICommand OpenIssuesCommand { get; }
        #endregion
    }
}
