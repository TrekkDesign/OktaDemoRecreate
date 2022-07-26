using System;
using System.Collections.Generic;
using OktaDemoRecreate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OktaDemoRecreate.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			InitializeComponent();
			BindingContext = new ProfileViewModel(this);
		}
	}
}

