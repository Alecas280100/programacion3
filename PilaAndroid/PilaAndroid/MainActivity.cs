﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace PilaAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button insertar = FindViewById<Button>(Resource.Id.btninsertar);
            Button eliminar = FindViewById<Button>(Resource.Id.btneliminar);
            Button mostrar = FindViewById<Button>(Resource.Id.btnmostrar);

            insertar.Click += (sender,e) =>
            {
                var inser = new Intent 
            }
        }
    }
}