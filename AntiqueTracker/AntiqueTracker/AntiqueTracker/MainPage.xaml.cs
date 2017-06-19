using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AntiqueStore
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Login(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        void Register(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
