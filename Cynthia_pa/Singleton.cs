using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {   
        //instancia interna del proyecto//
        private static Singleton instance = null;
        public string mensaje = "";

        protected Singleton() {
            mensaje = "hola mundo";
        }

        public static Singleton Instance
        //propiedad //
        {
            get
            //Propiedad para que se regrese la clase instanciada//
            {
                if (instance == null)
                    instance = new Singleton();
                //Si la propiedad instance es null crea uno nuevo//

                return instance;
            }
        }
    }
}
