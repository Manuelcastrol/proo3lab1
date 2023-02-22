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
        private string apellido;
        private int edad;
        private string departamento;
        private string municipio;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Municipio { get => municipio; set => municipio = value; }

        public void RegistroCliente()
        {
           
            WriteLine("\nPor favor ingrese sus nombres por favor.");
            

            WriteLine("\nPor favor le solicitamos que ponga sus apellidos");
            Apellido = ReadLine();

            WriteLine("\nPor favor digita tú edad");
            Edad = int.Parse(ReadLine());

            
            WriteLine("\n¿Por favor digita el departamento de donde vives?");
          
            string[] opciones = { "La Unión", "San Salvador", "San Miguel", "Sonsonate", "La Paz", "Cuscatlán" };
            for (int i = 0; i < opciones.Length; i++)
            {
                WriteLine($"{i + 1}-{opciones[i]}");
            }

            int opcionDepartamento = int.Parse(ReadLine());
            while (opcionDepartamento > opciones.Length || opcionDepartamento <= 0)
            {
                
                WriteLine($"La opcion ingresada = {opcionDepartamento} no se encuentra en la lista, Por favor vuelve a seleccionar un Departamento valido\n");
                
                for (int i = 0; i < opciones.Length; i++)
                {
                    WriteLine($"{i + 1}-{opciones[i]}");
                }
                opcionDepartamento = int.Parse(ReadLine());
            }

            Departamento = opciones[opcionDepartamento - 1];
            WriteLine($"\nEstos son los municipios de {Departamento}\n");

            switch (Departamento)
            {
                case "La Unión":
                    string[] muniChalatenango = { "San Alejo ", "Conchagua", "El Carmen", "Yayantique ", "Meanguera del Golfo", "La Unión " };
                    
                    WriteLine("\nElige el municipio ");
                    
                    for (int i = 0; i < muniChalatenango.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniChalatenango[i]}");
                    }
                    int opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniChalatenango[opcionMunicipio - 1];
                    break;

                case "San Salvador":
                    string[] muniSanSalvador = { "Antiguo Cuscatlan", "Santa Tecla", "Apopa", "Ciudad delgado", "Ilopango", "San Marcos" };
                    
                    WriteLine("\nElige el municipio ");
                    
                    for (int i = 0; i < muniSanSalvador.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniSanSalvador[i]}");
                    }
                    opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniSanSalvador[opcionMunicipio - 1];
                    break;

                case "San Miguel":
                    string[] muniSantaAna = { "	Chapeltique", "Ciudad Barrios", "Nueva Guadalupe", "Nuevo Edén de San Juan", "San Miguel", "Quelepa" };

                    WriteLine("\nElige el municipio ");
                    
                    for (int i = 0; i < muniSantaAna.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniSantaAna[i]}");
                    }
                    opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniSantaAna[opcionMunicipio - 1];
                    break;

                case "Sonsonate":
                    string[] muniSonsonate = { "Acajutla", "Armenia", "Caluco", "Izalco", "Cuisnahuat", "Nahulingo" };
                    
                    WriteLine("\nElige el municipio ");
                    
                    for (int i = 0; i < muniSonsonate.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniSonsonate[i]}");
                        ReadLine();
                    }
                    opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniSonsonate[opcionMunicipio - 1];
                    break;

                case "La Paz":
                    string[] muniLaLibertad = { "El Rosario", "Paraíso de Osorio", "San Luis Talpa", "Jerusalén", "Tapalhuaca", "Santa María Ostuma" };//
                    
                    WriteLine("\nElige el municipio ");
                    
                    for (int i = 0; i < muniLaLibertad.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniLaLibertad[i]}");
                    }
                    opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniLaLibertad[opcionMunicipio - 1];
                    break;

                case "Cuscatlán":
                    string[] muniSanVicente = { "San Ramón", "Suchitoto", "San Cristóbal", "San Pedro Perulapán", "Candelaria", "El Carmen" };//
                    
                    WriteLine("\nElige el municipio");
                    
                    for (int i = 0; i < muniSanVicente.Length; i++)
                    {
                        WriteLine($"{i + 1}-{muniSanVicente[i]}");
                    }
                    opcionMunicipio = int.Parse(ReadLine());
                    Municipio = muniSanVicente[opcionMunicipio - 1];
                    break;


            }


        }
        public String GetInformacion()
        {
            return "\nNombre: " + Nombre + "\nApellido: " + Apellido + "\nEdad: " + Edad + "\nDepartamento: " + Departamento + "\nMunicipio: " + Municipio;

        }

    }
}
