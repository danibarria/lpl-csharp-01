using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa de consola, que solicite lineas de la entrada estandar
             las almacene temporalmente para su ordenamiento y luego las liste en la salida estandar.
             Utilice ctrl + z para terminar el ingreso de lineas*/
            string[] argumentos = new string [30];
            
            var palabras = new List<string>();
            String argvalue;
           
            while ((argvalue = System.Console.ReadLine())!= null)
            {
                palabras.Add(argvalue);               
            }
            palabras.Sort();

            foreach(string j in palabras){
                System.Console.WriteLine(j);
            }
            System.Console.ReadKey();
        }
    }
}
