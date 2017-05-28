using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucklingChatMobile.ViewModels.Auth;
using Xamarin.Forms;

namespace DucklingChatMobile.Views.Auth
{
    class LoginView : ContentPage
    {
        private LoginViewModel ViewModel => _viewModel ?? (_viewModel = new LoginViewModel());
        private LoginViewModel _viewModel;

        public LoginView()
        {
            var usernameLabel = new Label
            {
                Text = "Username:"
            };
            var usernameEntry = new Entry();
            usernameEntry.SetBinding(Entry.TextProperty, "Username");



            var passwordLabel = new Label
            {
                Text = "Password:"
            };
            var passwordEntry = new Entry();
            passwordEntry.SetBinding(Entry.TextProperty, "Password");



            var submitButton = new Button
            {
                Text = "Submit"
            };
            submitButton.Clicked += async (o, args) => { await LoginClicked(); };

            var createButton = new Button
            {
                Text = "Create"
            };
            createButton.Clicked += async (o, args) => { await LoginClicked(); };


            var form = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Padding = 10,
                Spacing = 10,
                Opacity = .95,
                Children = { usernameLabel, usernameEntry,passwordLabel,passwordEntry,submitButton,createButton }
            };

            Content = form;
        }

        private Task LoginClicked()
        {
            ViewModel.Login();
            return null;
        }
    }
}
