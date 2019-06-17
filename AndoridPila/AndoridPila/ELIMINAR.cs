using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndoridPila
{
    [Activity(Label = "ELIMINAR")]
    public class ELIMINAR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Eliminar);
            TextView eliminado = FindViewById<TextView>(Resource.Id.lbleliminado);
            Button eliminar = FindViewById<Button>(Resource.Id.btneliminar);
            Pila<string> p = new Pila<string>();
            eliminar.Click += (sender, e) =>
            { 
                
                eliminado.Text = p.pop();

            };


        }
    }
}