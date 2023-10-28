using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Propiedad para que se cree el Singleton//s
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "hola marte";
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
