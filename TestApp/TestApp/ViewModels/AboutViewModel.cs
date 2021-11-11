using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public bool Enabled { get; set; }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Button1Command = new Command(async () => await Shell.Current.DisplayAlert("Button 1", "Button 1", "Cancel"), () => false);
            Button2Command = new Command(async () => await Shell.Current.DisplayAlert("Button 2", "Button 2", "Cancel"), () => true);
            Button3Command = new Command(async () => await Shell.Current.DisplayAlert("Button 3", "Button 3", "Cancel"), () => Enabled);
            ToggleEnableCommand = new Command(() => { Enabled = !Enabled; Button3Command.ChangeCanExecute(); });
        }

        public Command OpenWebCommand { get; }
        public Command Button1Command { get; }
        public Command Button2Command { get; }
        public Command Button3Command { get; }
        public Command ToggleEnableCommand { get; }
    }
}