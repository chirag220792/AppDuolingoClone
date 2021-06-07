using System;
using AppDuolingoClone.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
namespace AppDuolingoClone.iOS.Renderers
{
    public class CustomNavigationPageRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if(Toolbar != null)
            {
                Toolbar.SizeToFit();
                Toolbar.Frame = new CoreGraphics.CGRect
                {
                    X = 0,
                    Y = View.Bounds.Height - Toolbar.Frame.Height,
                    Width = View.Bounds.Width,
                    Height = 70
                };
            }
        }
    }
}
