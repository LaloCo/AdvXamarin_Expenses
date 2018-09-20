using System;
using CoreGraphics;
using ExpensesApp.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomProgressBarRenderer))]
namespace ExpensesApp.iOS.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            LayoutSubviews();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            float x = 1.0f;
            float y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(x, y);
            Transform = transform;
        }
    }
}
