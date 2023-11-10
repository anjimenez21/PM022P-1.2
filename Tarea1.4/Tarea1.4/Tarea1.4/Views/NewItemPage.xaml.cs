using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tarea1._4.Models;
using Tarea1._4.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1._4.Views
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