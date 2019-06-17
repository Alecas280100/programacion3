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
    [Activity(Label = "INSERTAR")]
    public class INSERTAR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Insertar);
            EditText numero = FindViewById<EditText>(Resource.Id.txtintroducirElemento);
            Button agregar = FindViewById<Button>(Resource.Id.btnAGREGAR);
            TextView res = FindViewById<TextView>(Resource.Id.txtresultado);
            Pila<string> p = new Pila<string>();
            agregar.Click += (sender, e) =>
            {
                string n;
                n = numero.Text;
                p.push(n);                             

            };
        }
    }
}