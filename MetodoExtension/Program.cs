using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nombre = "Luis Felipe Gil Lamaignere";

            Console.WriteLine(nombre.ContarPalabras());
            Console.WriteLine(nombre.Reemplazame("u","A"));
            Console.ReadLine();
        }
    }
}
