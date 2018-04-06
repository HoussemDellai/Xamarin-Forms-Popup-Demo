using System;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace PopupApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void ShowPopup(object o, EventArgs e)
	    {
	        PopupNavigation.Instance.PushAsync(new MyPopupPage());
	    }

	    private void ShowNewUserPopup(object o, EventArgs e)
	    {
	        PopupNavigation.Instance.PushAsync(new NewUserPopupPage());
	    }
    }
}
