using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DucklingChatMobile.Views
{
    class DashBoardView : ContentPage
    {
        public DashBoardView()
        {
            var stack = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "DashboardView"
                    }
                }
            };
            Content = stack;
        }

    }
}
