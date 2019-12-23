using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPhoneHomeQuickActions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public bool ManageMenuAction(string action)
        {
            switch (action)
            {
                case MenuActions.ShowPage1:
                    (MainPage as NavigationPage).CurrentPage.Navigation.PushAsync(new Page1());
                    return true;
                case MenuActions.ShowPage2:
                    (MainPage as NavigationPage).CurrentPage.Navigation.PushAsync(new Page2());
                    return true;
                case MenuActions.ShowPage3:
                    (MainPage as NavigationPage).CurrentPage.Navigation.PushAsync(new Page3());
                    return true;
            }

            return false;
        }
    }
}
