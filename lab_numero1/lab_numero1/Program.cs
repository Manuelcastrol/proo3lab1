using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab_numero1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona pers = new persona();
            WriteLine("INGRESE LOS DATOS DE LA PERSONA ");
            ReadLine();
            string perso = ReadLine();

            WriteLine("INGRESE EL NOMBRE");
            pers.Nombre = ReadLine();
            WriteLine("INGRESE LA EDAD");
            pers.Edad = Convert.ToInt32(ReadLine());
            WriteLine("LOS DATOS INGRESADOS SON: \n" + "NOMBRE:" + pers.Nombre + "\n" + "EDAD:" + pers.Edad);
            string datos = ReadLine();

            vivienda vivien = new vivienda();
            WriteLine("INGRESE EL DEPARTAMENTO");
            vivien.Departamento = ReadLine();
            WriteLine("INGRESE SU MUNICIPIO");
            vivien.Municipio = ReadLine();
            WriteLine("MUCHAS GARCIAS A LA PERSONA CON EL NOMBRE DE "+ "" + pers.Nombre+ "" + "\nY CON LA EDAD DE "+ "" +pers.Edad+ "" +" QUE VIVE EN EL MUNICIPÍO "+ "" +vivien.Municipio+
                "\nDEL DEPARTAMENTO "+"" + vivien.Departamento+ "" + " FIN 6♦♪☺☼ ");
            string pe = ReadLine();

        }

    }

}

           /* WriteLine("BUUEENAS");
            WriteLine(" MENU " +
                "\n 1- ejecutar" +
                "\n 2- salir ");
            int opcion = int.Parse(ReadLine());

            while (opcion >= 2)
            {
                
            }
            */