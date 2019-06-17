using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace ejer2final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText plc = FindViewById<EditText>(Resource.Id.txtplaca);
            Button registrar = FindViewById<Button>(Resource.Id.btnregistrar);
            Button mostrar = FindViewById<Button>(Resource.Id.btnmostrar);
            EditText mont = FindViewById<EditText>(Resource.Id.txtmonto);
            EditText tipo = FindViewById<EditText>(Resource.Id.txttipo);
            EditText ingres = FindViewById<EditText>(Resource.Id.txtingreso);
            EditText sal = FindViewById<EditText>(Resource.Id.txtsalida);
        }
    }
}