﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInPage.Views;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace SignInPage.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        void LoginClicked(System.Object sender, System.EventArgs e)
        {
            if (Preferences.ContainsKey("username") && Preferences.Get("username", "") == username.Text)
            {
                if(Preferences.Get("password", "") == password.Text)
                {
                    DisplayAlert("Login Successful", $"{username.Text} is signed in!", "OK");
                }

            }
            else
            {
                DisplayAlert("Login Failed", $"{username.Text} NOT exist!", "OK");
            }

        }
    }
}
