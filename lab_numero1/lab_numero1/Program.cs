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
            persona persona = new persona();
            persona.RegistroCliente();

            Console.WriteLine(persona.GetInformacion());
            Console.ReadLine();

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