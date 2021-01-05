﻿using CW.Views.InsideViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CW.ViewModels.InsideViewModels
{
    public class MainScreenViewModel : BaseViewModel
    {
        private bool _isEnabled;

        public MainScreenViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _isEnabled = true;
            OpenProfilePageCommand = new Command(OpenProfilePage);
            BackCommand = new Command(Back, () => _isEnabled);
        }

        public INavigation Navigation { get; private set; }
        public ICommand BackCommand { get; private set; }


        private void Back()
        {
            Navigation.PopAsync();
        }

        private void OpenProfilePage()
        {
            Navigation.PushAsync(new ProfileView(new ProfileViewModel(Navigation)));
        }

        public ICommand OpenProfilePageCommand { get; private set; }
    }
}
