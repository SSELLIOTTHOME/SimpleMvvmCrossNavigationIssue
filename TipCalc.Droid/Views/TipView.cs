using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.Droid.Views
{
    [Activity(Label = "Tip Calculator", MainLauncher = true)]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipView);
            var b = FindViewById<TextView>(Resource.Id.buttton1);
            b.Click += B_Click;


            

        }

        private async void B_Click(object sender, System.EventArgs e)
        {
            await Mvx.Resolve<IMvxNavigationService>().Navigate<TestViewModel>();
        }

        protected async override void OnViewModelSet()
        {
            base.OnViewModelSet();
           
        }


        protected async override void OnResume()
        {
            base.OnResume();
            
        }

    }
}