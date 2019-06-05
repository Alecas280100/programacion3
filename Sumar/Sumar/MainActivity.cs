using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Sumar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText A = FindViewById<EditText>(Resource.Id.txtA);
            EditText B = FindViewById<EditText>(Resource.Id.txtB);
            Button calcular = FindViewById<Button>(Resource.Id.suma);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtresultado);

            calcular.Click += (sender, e) =>
            {
                int a = int.Parse(A.Text);
                int b = int.Parse(B.Text);
                resultado.Text = (a + b).ToString();
            };
        }
    }
}