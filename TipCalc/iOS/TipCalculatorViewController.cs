using System;

using UIKit;

namespace TipCalc.iOS
{
   public partial class TipCalculatorViewController : UIViewController
   {
      private readonly TipCalculator _tipCalculator = new TipCalculator();

      public TipCalculatorViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         Title = "TipCalc";

         Calculate.TouchUpInside += (s, e) =>
         {
            var amount = Convert.ToDecimal(BillAmount.Text);
            TipAmount.Text = _tipCalculator.Calculate(amount).ToString("C2");
         };

         Calculate.Enabled = false;
         BillAmount.AddTarget((s, e) => Calculate.Enabled = !string.IsNullOrEmpty(BillAmount.Text),
                              UIControlEvent.EditingChanged);
      }
   }
}
