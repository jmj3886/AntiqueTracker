using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(AntiqueTracker.Droid.FlatButtonRenderer))]
namespace AntiqueTracker.Droid
    {
        public class FlatButtonRenderer : ButtonRenderer
        {
            protected override void OnDraw(Android.Graphics.Canvas canvas)
            {
                base.OnDraw(canvas);
            }
        }
    }
