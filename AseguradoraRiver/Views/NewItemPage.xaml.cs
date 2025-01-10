using System;
using System.Collections.Generic;
using System.ComponentModel;
using AseguradoraRiver.Models;
using AseguradoraRiver.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AseguradoraRiver.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}