﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherHiring.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformacionPage : ContentPage
    {
        InformacionViewModel viewModel;
        public InformacionPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new InformacionViewModel();
        }
    }
}