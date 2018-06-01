using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejemplos31May.Class;

namespace Ejemplos31May
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Parameter Count = (0)", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[(0)] = [(1)]", i, args[i]);
            }
            int[] arreglo1 = new int[3];
            int[] arreglo2 = { 1, 2, 3 };
            int[,] mat1 = new int[2, 2];

            int[] numeros = {1,2,3,4,5,6,7,8,91,2,3,4,5};


            foreach (int j in numeros)
            {
                System.Console.WriteLine(j);
            }
            Persona per = new Persona();
            per.ToString();
            System.Console.WriteLine(per.ToString());
            System.Console.ReadKey();
        }
    }

    #region
    //para definir regiones, 
    //case sensitive
    //debe empezar con una lera o signo
    //no pueden tener espacios en blanco
    //const tipo nombre
    //fuertemente tipado
    //
    #endregion
}