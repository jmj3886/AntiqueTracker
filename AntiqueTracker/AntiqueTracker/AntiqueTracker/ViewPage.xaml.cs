using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AntiqueTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewPage : ContentPage
	{

        public string Name = "Mr. Darby's Antique Emporium";
       

        public ViewPage ()
		{
			InitializeComponent ();
		}

        void GetDirections(object sender, EventArgs args)
        {
            var address = "8574 Market St, Boardman, OH 44512";

            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    Device.OpenUri(
                      new Uri(string.Format("http://maps.apple.com/?q={0}", WebUtility.UrlEncode(address))));
                    break;
                case TargetPlatform.Android:
                    Device.OpenUri(
                      new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode(address))));
                    break;
                case TargetPlatform.Windows:
                case TargetPlatform.WinPhone:
                    Device.OpenUri(
                      new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString(address))));
                    break;
            }
        }
    }
}
