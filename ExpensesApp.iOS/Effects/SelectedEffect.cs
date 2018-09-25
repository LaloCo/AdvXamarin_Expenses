using System;
using ExpensesApp.iOS.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("LPA")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.iOS.Effects
{
    public class SelectedEffect : PlatformEffect
    {
        public SelectedEffect()
        {
        }

        protected override void OnAttached()
        {

        }

        protected override void OnDetached()
        {

        }
    }
}
