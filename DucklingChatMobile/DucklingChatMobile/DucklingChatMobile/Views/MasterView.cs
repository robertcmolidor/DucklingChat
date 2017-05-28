using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DucklingChatMobile.Views
{
    class MasterView : MasterDetailPage
    {
        public MasterView()
        {
            Master = new MainNavigationView();
            MasterBehavior = MasterBehavior.Default;

            Detail = new NavigationPage(new DashBoardView())
            {
                BarBackgroundColor = Color.Teal,
                BarTextColor = Color.Black
            };

            if (App.Navigation == null)
            {
                App.Navigation = Detail.Navigation;
            }
            App.MasterDetailPage = this;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var navigationPage = Detail as NavigationPage;

            if (navigationPage == null) return;


            App.Navigation = navigationPage.Navigation;
        }
    }
}
