// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmTipCalc.iOS.Views
{
    [Register ("TipCalcView")]
    partial class TipCalcView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField BillAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Calculate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipAmount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BillAmount != null) {
                BillAmount.Dispose ();
                BillAmount = null;
            }

            if (Calculate != null) {
                Calculate.Dispose ();
                Calculate = null;
            }

            if (TipAmount != null) {
                TipAmount.Dispose ();
                TipAmount = null;
            }
        }
    }
}