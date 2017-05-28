using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DucklingChatMobile.Views
{
    class MainNavigationView : ContentPage
    {
        public MainNavigationView()
        {
            Title = "Menu";
            
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                
            };
            stack.Children.Add(new Label
            {
                Text = "navigation"
            });

            Content = stack;

        }

    }
}
