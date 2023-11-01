using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11_SMN_11_ACT_1_7
{
    internal class Program
    {
        static List<double> notas = new List<double>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Menu();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        RegistrarNotas();
                        break;
                    case "2":
                        NotaMayor();
                        break;
                    case "3":
                        NotaMenor();
                        break;
                    case "4":
                        EncontrarNota();
                        break;
                    case "5":
                        ModificarNota();
                        break;
                    case "6":
                        NotasRegistradas();
                        break;
                    case "7":
                        Console.WriteLine("");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. ");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("===========================\n" +
            "Casos con arreglos\n" +
            "===========================\n" +
            "1: Registrar notas\n" +
            "2: Hallar la nota mayor\n" +
            "3: Hallar la nota menor\n" +
            "4: Encontrar una nota\n" +
            "5: Modificar una nota\n" +
            "6: Ver notas registradas\n" +
            "7: Salir\n" +
            "===========================");
            Console.Write("Ingrese una opción: ");
        }

        static void RegistrarNotas()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("===========================\n" +
                "Registrar una nota\n" +
                "===========================");
                Console.Write("Ingrese una nota: ");
                if (double.TryParse(Console.ReadLine(), out double nota))
                {
                    notas.Add(nota);
                    Console.WriteLine("Nota agregada");
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }

                Console.WriteLine("===========================\n" +
                "1: Registrar otra nota\n" +
                "2: Regresar");
                Console.Write("Ingrese una opción:");
                string opcion = Console.ReadLine();
                if (opcion == "2")
                {
                    return;
                }
            }
        }

        static void NotaMayor()
        {
            Console.Clear();
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas");
            }
            else
            {
                double mayor = notas.Max();
                Console.WriteLine("===========================\n"+
                "La nota mayor\n"+
                "===========================\n" +
                $"La nota mayor es: {mayor}\n");
                Console.WriteLine(string.Join(" ", notas));
            }

            Console.WriteLine("===========================\n" +
            "1: Regresar\n");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
        }

        static void NotaMenor()
        {
            Console.Clear();
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                double menor = notas.Min();
                Console.WriteLine("===========================\n" +
                "La nota menor\n" +
                "===========================\n" +
                $"La nota menor es: {menor}\n");
                Console.WriteLine(string.Join(" ", notas));
            }

            Console.WriteLine("===========================\n" +
            "1: Regresar\n");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
        }

        static void EncontrarNota()
        {
            Console.Clear();
            if (notas.Count == 0)
            {
                Console.WriteLine("No Registra Notas");
            }
            else
            {
                Console.WriteLine("===========================\n" +
                "Buscar nota\n" +
                "===========================\n");
                Console.Write("Ingrese la nota a buscar: ");
                if (double.TryParse(Console.ReadLine(), out double notaBuscada))
                {
                    int posicion = notas.IndexOf(notaBuscada);
                    if (posicion != -1)
                    {
                        Console.WriteLine($"La nota está en la posición: {posicion}");
                    }
                    else
                    {
                        Console.WriteLine("La nota no se encuentra.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }

            Console.WriteLine("===========================\n" +
            "1: Regresar\n");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
        }

        static void ModificarNota()
        {
            Console.Clear();
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                Console.WriteLine("===========================\n" +
                "Modificar una nota\n" +
                "===========================");
                Console.Write("Ingrese la posición: ");
                if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < notas.Count)
                {
                    Console.Write("Ingrese el nuevo valor: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevaNota))
                    {
                        Console.WriteLine("===========================\n"+
                        "Antes:\n");
                        Console.WriteLine(string.Join(" ", notas));
                        notas[posicion] = nuevaNota;
                        Console.WriteLine("Después:");
                        Console.WriteLine(string.Join(" ", notas));
                    }
                    
                }
                
            }

            Console.WriteLine("===========================\n" +
            "1: Regresar\n ");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
        }

        static void NotasRegistradas()
        {
            Console.Clear();
            Console.WriteLine("===========================\n" +
            "Notas registradas\n" +
            "===========================\n" +
            "Notas actuales: \n");
            Console.WriteLine(string.Join(" - ", notas));
            Console.WriteLine($"Siguiente posición será: {notas.Count}\n" +
            "===========================\n" +
            "1: Regresar\n");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
        }
    }
}

