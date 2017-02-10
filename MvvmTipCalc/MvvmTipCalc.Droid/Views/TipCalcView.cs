using Android.App;
using Android.OS;

namespace MvvmTipCalc.Droid.Views
{
   [Activity(Label = "TipCalc")]
   public class TipCalcView : BaseView
   {
      protected override int LayoutResource => Resource.Layout.tip_calculator;

      protected override void OnCreate(Bundle bundle)
      {
         base.OnCreate(bundle);

         SupportActionBar.SetDisplayHomeAsUpEnabled(false);
      }
   }
}
