using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AntiqueStore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        void AddStore(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AddPage());
        }

        void ViewStore(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ViewPage());
        }
    }
}
