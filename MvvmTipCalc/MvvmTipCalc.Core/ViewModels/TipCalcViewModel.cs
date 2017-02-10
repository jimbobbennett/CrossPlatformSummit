using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace MvvmTipCalc.Core.ViewModels
{
   public class TipCalcViewModel : MvxViewModel
   {
      private TipCalculator _tipCalculator = new TipCalculator();
      
      private decimal _billAmount;
      public decimal BillAmount
      {
         get { return _billAmount; }
         set
         {
            if (SetProperty(ref _billAmount, value))
               _calculateCommand.RaiseCanExecuteChanged();
         }
      }

      private decimal _tipAmount;
      public decimal TipAmount
      {
         get { return _tipAmount; }
         set { SetProperty(ref _tipAmount, value); }
      }

      private MvxCommand _calculateCommand;
      public ICommand CalculateCommand => _calculateCommand ?? (_calculateCommand = new MvxCommand(Calculate, CanCalculate));

      private void Calculate() => TipAmount = _tipCalculator.Calculate(BillAmount);
      private bool CanCalculate() => BillAmount > 0;
  }
}
