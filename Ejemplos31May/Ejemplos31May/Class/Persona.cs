using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplos31May.Class
{
    class Persona
    {
        public int Edad { get; set; }
        public int Dni { get; set; }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set {
                if (value == "")
                    throw new Exception("no apellidos vacios");
                    _apellido = value; }
        }
        
        public void TomarMate() 
        {
            System.Console.WriteLine("Tomando unos amargos");
        }
    }
}
