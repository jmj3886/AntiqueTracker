using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AntiqueStore
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new HomePage());
        }
    }
}
