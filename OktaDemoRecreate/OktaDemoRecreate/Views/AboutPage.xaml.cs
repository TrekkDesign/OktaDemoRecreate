using System;
using System.ComponentModel;
using OktaDemoRecreate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OktaDemoRecreate.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel(this);
        }
    }
}
