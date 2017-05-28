using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucklingChatMobile.Views;
using DucklingChatMobile.Views.Auth;
using Xamarin.Forms;

namespace DucklingChatMobile
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetailPage { get; set; }
        public static INavigation Navigation { get; set; }
        public App()
        {
            MainPage = new LoginView();
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
    }
}
