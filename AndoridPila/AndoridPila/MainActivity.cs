using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace AndoridPila
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //ESTA TAREA LA INTENTAMOS CON ALEJANDRO CASTRO. INGE
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button Insertar = FindViewById<Button>(Resource.Id.btnInsertar);
            Button Eliminar = FindViewById<Button>(Resource.Id.btnEliminar);
            Button Mostrar = FindViewById<Button>(Resource.Id.btnMostrar);

            Insertar.Click += (sender, e) =>
            {
                var insertar = new Intent(this, typeof(INSERTAR));
                insertar.PutExtra("Datos", "Datos Enviados");
                StartActivity(insertar);
            };
            Eliminar.Click += (sender, e) =>
            {
                var eliminar = new Intent(this, typeof(ELIMINAR));
                eliminar.PutExtra("Datos", "Datos Enviados");
                StartActivity(eliminar);
            };
            Mostrar.Click += (sender, e) =>
            {
                var mostrar = new Intent(this, typeof(MOSTRAR));
                mostrar.PutExtra("Datos", "Datos Enviados");
                StartActivity(mostrar);
            };
        }
    }
}