using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePattern
{
    class SingleObject
    {
        private static SingleObject instance=null;
        private SingleObject()
        {
            instance = null;
        }
        public static SingleObject getInstance()
        {
            if (instance == null)
            { 
               instance = new SingleObject();
               return instance;
            }

            else
                return instance;
        }
        public void ShowMethod()
        {
            Console.WriteLine("Soy Singleton");
        }
    }
}
