using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.Droid.Views
{
    [Activity]
    public class TestView : MvxActivity<TestViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipView2);

            var b = FindViewById<TextView>(Resource.Id.buttton1);
            b.Click += B_Click;
        }

        private async void B_Click(object sender, System.EventArgs e)
        {
            await Mvx.Resolve<IMvxNavigationService>().Close(this.ViewModel);
        }

        protected async override void OnResume()
        {
            base.OnResume();
          
        }
    }
}