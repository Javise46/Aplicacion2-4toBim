using System;
using System.IO;

namespace Aplicacion2_4toBim
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            string direccion = "";
            string linea = "";

            while (op == 0)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("-------Cinta De Opciones-------");
                Console.WriteLine("\n1. Crear o Sobreescribir archivo \n2. Ver Archivo \n3. Salir ");
                Console.WriteLine("Digite el numero de opcion que desea");
                Console.WriteLine("----------------------------------------------");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                if (op == 1)
                {
                    Console.WriteLine("Escribe el Nombre del Archivo");
                    direccion = Console.ReadLine() + ".txt";
                    Console.WriteLine("Escribe lo que deseas");
                    linea = Console.ReadLine();
                    Escribir(direccion, linea);
                    op = 0;
                }
                else if (op == 2)
                {
                    Console.WriteLine("Escribe El Nombre Del Contacto");
                    String nombre = Console.ReadLine()+ ".txt";
                    Buscar(nombre);
                    Console.ReadKey();
                    op = 0;
                }
                else if (op == 3)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        static void Escribir(string ruta, string dato)
        {

            StreamWriter ar;
            ar = File.AppendText(ruta);
            ar.WriteLine(dato);
            ar.Close();
        }
        static void Buscar(string ruta)
        {
          
            StreamReader ar;
            ar = File.OpenText(ruta);
            String line;
            line = ar.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = ar.ReadLine();
            }
            ar.Close();
            Console.ReadLine();
           
        }
    }

}
