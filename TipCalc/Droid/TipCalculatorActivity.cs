using Android.App;
using Android.Support.V7.Widget;
using Android.OS;
using System;
using Android.Support.V7.App;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace TipCalc.Droid
{
   [Activity(Label = "TipCalc", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/MyTheme")]
   public class TipCalculatorActivity : AppCompatActivity
   {
      protected Toolbar Toolbar { get; set; }

      private Button Calculate { get; set; }
      private EditText BillAmount { get; set; }
      private TextView TipAmount { get; set; }

      private readonly TipCalculator _tipCalculator = new TipCalculator();

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         SetContentView(Resource.Layout.tip_calculator);

         Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
         if (Toolbar != null)
         {
            SetSupportActionBar(Toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(false);
         }

         Calculate = FindViewById<Button>(Resource.Id.calculate);
         BillAmount = FindViewById<EditText>(Resource.Id.bill_amount);
         TipAmount = FindViewById<TextView>(Resource.Id.tip_amount);

         Calculate.Click += (s, e) =>
         {
            var amount = Convert.ToDecimal(BillAmount.Text);
            TipAmount.Text = _tipCalculator.Calculate(amount).ToString("C2");
         };

         Calculate.Enabled = false;
         BillAmount.TextChanged += (s, e) => Calculate.Enabled = !string.IsNullOrEmpty(BillAmount.Text);
      }
   }
}