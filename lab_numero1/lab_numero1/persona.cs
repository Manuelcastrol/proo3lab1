using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab_numero1
{
    internal class persona
    {
        
            private string nombre;
            private int edad;

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }


            public void informacion(string Nombre, int Edad)
            {

                this.Nombre = Nombre;
                this.edad = Edad;
                WriteLine("REGISTRE SUS DATOS \n");
                WriteLine("POR FAVOR INGRESE SU NOMBRE \n");
                nombre = ReadLine();
                WriteLine("POR FAVOR INGRESE SU EDAD \n");
                edad = Convert.ToInt32(ReadLine());

            }
        
    }
}
