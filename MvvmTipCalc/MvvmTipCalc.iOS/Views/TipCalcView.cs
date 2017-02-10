using System;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvvmTipCalc.Core.ViewModels;
using MvvmTipCalc.Core.Converters;

namespace MvvmTipCalc.iOS.Views
{
   [MvxFromStoryboard]
   public partial class TipCalcView : MvxViewController<TipCalcViewModel>
   {
      public TipCalcView(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         var set = this.CreateBindingSet<TipCalcView, TipCalcViewModel>();
         set.Bind(BillAmount).To(vm => vm.BillAmount).WithConversion("DecimalToString");
         set.Bind(Calculate).To(vm => vm.CalculateCommand);
         set.Bind(TipAmount).To(vm => vm.TipAmount).WithConversion("DecimalToCurrency");
         set.Apply();
      }
   }
}

