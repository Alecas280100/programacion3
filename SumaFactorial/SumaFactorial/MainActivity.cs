using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace SumaFactorial
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText n = FindViewById<EditText>(Resource.Id.txtn);
            Button calcular = FindViewById<Button>(Resource.Id.btncalcular);
            RadioButton suma = FindViewById<RadioButton>(Resource.Id.rbnsumatoria);
            RadioButton facto = FindViewById<RadioButton>(Resource.Id.rbnfactorial);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtresultado);

            calcular.Click += (sender, e) =>
            {
                int numero= int.Parse(n.Text);
                int sol = 0;
                if(suma.Checked)
                {

                    sol = SumaFactorial.operaciones.getInstancia().sumatoria(numero);
                }
                if(facto.Checked)
                {
                    sol=SumaFactorial.operaciones.getInstancia().factorial(numero);
                }

                resultado.Text = sol.ToString();
            };
                
        }
    }
}