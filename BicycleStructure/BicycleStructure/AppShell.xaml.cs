﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BicycleStructure
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}