using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public bool SubscribedSession { get; set; }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            ShareCommand = new Command(async () => await Shell.Current.DisplayAlert("hi", "test message", "cancel"), () => SubscribedSession);
            ShareCommand2 = new Command(async () => await Shell.Current.DisplayAlert("hi", "test message", "cancel"), () => true);
        }

        public ICommand OpenWebCommand { get; }
        public ICommand ShareCommand { get; }
        public ICommand ShareCommand2 { get; }
    }
}