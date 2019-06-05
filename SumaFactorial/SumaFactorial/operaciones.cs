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

namespace SumaFactorial
{
    class operaciones
    {
        private static operaciones Instancia;
        
        public int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return factorial(n - 1) * n;
        }
        public int sumatoria(int n)
        {
            if (n == 0)
                return 0;
            else
                return sumatoria(n - 1) + n;
        }
        public static operaciones getInstancia() //singleton
        {
            if (Instancia == null)
            {
                Instancia = new operaciones();
            }
            return Instancia;
        }
    }
}