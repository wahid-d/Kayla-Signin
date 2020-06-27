using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace SignInPage.Views
{
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        async void SignupClicked(System.Object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(username.Text) ||
                string.IsNullOrEmpty(email.Text) ||
                string.IsNullOrEmpty(password.Text) ||
                string.IsNullOrEmpty(confirm.Text))
            {
                DisplayAlert("Error", "Fill in all fields", "OK");
                return;
            }

            if(password.Text != confirm.Text)
            {
                DisplayAlert("Error", "passwords dont match", "OK");
                return;
            }

            Preferences.Set("username", username.Text);
            Preferences.Set("password", password.Text);
            Preferences.Set("email", email.Text);

            DisplayAlert("Congrats", "Successfully signed UP!", "OK");

            await Navigation.PopAsync();
        }
    }
}
