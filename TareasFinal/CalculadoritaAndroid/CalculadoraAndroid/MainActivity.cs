using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using static Android.App.ActionBar;

namespace CalculadoraAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /* btnObtener;
         n;
        textBoxHolder;
         _TextosEdicion;*/
         
        
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        EditText inversionInicial=FindViewById<EditText>(Resource.Id.txtperiodos); 
          EditText tasa   = FindViewById<EditText>(Resource.Id.txttasa);
        
          Button  btnObtener = FindViewById<Button>(Resource.Id.btncrearflujos);
           Button btnCalcula = FindViewById<Button>(Resource.Id.btncalcular);
          LinearLayout   textBoxHolder = FindViewById<LinearLayout>(Resource.Id.listatxt);
           EditText n = FindViewById<EditText>(Resource.Id.txtperiodos);
            TextView res = FindViewById<TextView>(Resource.Id.lblresultado);
          
            double[] flujos;
          List<EditText>  _TextosEdicion = new List<EditText>();

          
            btnObtener.Click += (sender, e) =>
            {
                flujos = new double[int.Parse(n.Text)];
                for (int i = 1; i <= int.Parse(n.Text); i++)
                {
                    var editText = new EditText(this);
                    editText.Tag = $"Flujo {i}";

                    var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                    layoutParams.BottomMargin = 2;

                    editText.LayoutParameters = layoutParams;

                    editText.Hint = $"Introduzca Flujo # {i}";


                    _TextosEdicion.Add(editText);

                    textBoxHolder.AddView(editText);
                    if (editText.Text == "")
                    {
                        editText.Text = "0";
                     
                    }
                    else
                    {
                        editText.Text = "0";
                     
                    }
                    flujos[i - 1] = double.Parse(editText.Text);
                }

            };

            btnCalcula.Click += (sender, e) =>
            {
                flujos = new double[int.Parse(n.Text)];
                foreach (EditText editor in _TextosEdicion)
                {
                    string valor = editor.Text;
                }
                int numero;
                double interes,IO;
               
                interes = double.Parse(tasa.Text);
                numero =int.Parse( n.Text);
                IO = double.Parse(inversionInicial.Text);
                List<EditText> aux = new List<EditText>();
                aux = _TextosEdicion;
                
                CalculadoraFinanciera van = new CalculadoraFinanciera(numero,interes);
               res.Text= van.VAN(IO, flujos).ToString();

            };


        }

        
    }
}