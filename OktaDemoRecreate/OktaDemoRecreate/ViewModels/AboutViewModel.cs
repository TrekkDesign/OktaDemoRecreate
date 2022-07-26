using System;
using System.Windows.Input;
using Okta.Xamarin;
using Okta.Xamarin.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OktaDemoRecreate.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel() : base()
        { }

        public AboutViewModel(ContentPage page)
        {
            this.Page = page;
            this.SignInCommand = new SignInCommand();
            GoToProfileCommand = new Command(async () => await Shell.Current.GoToAsync("//ProfilePage"));
            OktaContext.AddAuthenticationFailedListener(this.OnAuthenticationFailed);
        }

        /// <summary>
		/// Gets or sets the command used to sign in.
		/// </summary>
		public SignInCommand SignInCommand { get; }

        /// <summary>
		/// Sends user to profile page.
		/// </summary>
		public ICommand GoToProfileCommand { get; }
    }
}
