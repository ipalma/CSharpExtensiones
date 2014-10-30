using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    //Los métodos de extensión solo puede ser estatico.
    public static class MisExtensiones
    {
        //Esto es un metodo de extension para String, ¿cómo?, al definir los parámetros lo llamamos con this y el tipo al que se extiende.
        public static int ContarPalabras(this String texto)
        {
            var pal = texto.Split(' ');
            return pal.Length;
        }

        public static String Reemplazame(this String texto, String origen, String destino)
        {
            var res = texto.Replace(origen, destino);
            return res;
        }




    }
}
