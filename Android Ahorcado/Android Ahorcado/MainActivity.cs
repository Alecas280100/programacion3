using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Android_Ahorcado
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText letra = FindViewById<EditText>(Resource.Id.txtletra);
            Button bletra = FindViewById<Button>(Resource.Id.btningresar);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtresultado);

            bletra.Click += (sender, e) =>
            {
                char l = letra.Text[0];
                string resul = Android_Ahorcado.Ahorcado.getInstancia().Buscar(l);
                resultado.Text = resul;
            };
        }
    }
}