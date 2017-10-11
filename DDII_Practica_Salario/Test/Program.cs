using DDII_Practica_Salario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDII_Practica_Salario
{
    class Program
    {
        public static float IMPUESTOS = 17;
        static void Main(string[] args)
        {
            bool continuar;
            String nombre;
            String apellidos;
            List<Persona> lista = new List<Persona>();
            Persona p1;
            do
            {
                Console.Clear();
                continuar = false;
                Console.WriteLine("Hola, introduzca el nombre de la persona: ");
                nombre = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Introduzca los apellidos: ");
                apellidos = Console.ReadLine();
                p1 = new Persona(nombre, apellidos);
                Console.Clear();
                Console.WriteLine("Introduzca las horas trabajadas:");
                p1.Horas = validarFloat();
                Console.Clear();
                Console.WriteLine("Introduzca el precio por hora:");
                p1.PrecioHora = validarFloat();
                lista.Add(p1);
                Console.Clear();
                Console.WriteLine("¿Quieres introducir mas empleados?");
                continuar = validarS_N();
            } while (continuar);
            imprimirSalario(lista);
        }

        private static int validarEnteros()
        {
            int aux=0;
            bool esCorrecto;
            do
            {
                esCorrecto = false;
                Console.Write("Introduzca un número entero: ");
                esCorrecto = Int32.TryParse(Console.ReadLine(), out aux);
                if (!esCorrecto)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: No has introducido un número.");
                }
                if (aux < 0 && esCorrecto)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: No has introducido un número positivo");
                }
            } while (!esCorrecto);
            return aux;
        }
        private static float validarFloat()
        {
            float aux = 0;
            bool esCorrecto;
            do
            {
                esCorrecto = false;
                Console.Write("Introduzca un número: ");
                esCorrecto = float.TryParse(Console.ReadLine(), out aux);
                if (!esCorrecto)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: No has introducido un número.");
                }
                if (aux < 0 && esCorrecto)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: No has introducido un número positivo");
                }
            } while (!esCorrecto);
            return aux;
        }
        private static void imprimirSalario(List<Persona> listaPersonas)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(("\tNombre y apellidos".PadRight(40, '-')) + "Salario".PadLeft(35, '-')+"\n");
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine((("\t"+p.toString()).PadRight(40, '-')) + (p.salario() + " Eur").ToString().PadLeft(35, '-')+"\n");
            }
        }
        private static bool validarS_N()
        {
            bool esCorrecto;
            bool aux;
            string stringAux;
            Console.Clear();
            do
            {
                esCorrecto = false;
                Console.Write("Introduzca \"s\" para SI o \"n\" para NO:");
                stringAux=Console.ReadLine().ToLower();
                esCorrecto = (stringAux == "s"||stringAux=="n");
                if (!esCorrecto)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR no has introducido una opción valida.");
                }
                aux = stringAux == "s";
            } while (!esCorrecto);
            return aux;
        }
    }
}
