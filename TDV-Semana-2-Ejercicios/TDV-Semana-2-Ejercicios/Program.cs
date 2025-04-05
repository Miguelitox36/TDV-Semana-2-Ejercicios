using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDV_Semana_2_Ejercicios
{
    internal class Program
    {
        static List<Figure> figures = new List<Figure>();
        
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- MENÚ DE FIGURAS ---");
                Console.WriteLine("1. Agregar rectángulo");
                Console.WriteLine("2. Agregar cuadrado");
                Console.WriteLine("3. Agregar círculo");
                Console.WriteLine("4. Agregar triángulo");
                Console.WriteLine("5. Ver todas las figuras");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddRectangle();
                        break;
                    case "2":
                        AddSquare();
                        break;
                    case "3":
                        AddCircle();
                        break;
                    case "4":
                        AddTriangle();
                        break;
                    case "5":
                        ShowFigure();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }


        }

        static void AddRectangle()
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Base: ");
            double baseR = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double widthR = double.Parse(Console.ReadLine());

            figures.Add(new Rectangle(name, baseR, widthR));
        }

        static void AddSquare()
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Lado: ");
            double side = double.Parse(Console.ReadLine());

            figures.Add(new Square(name, side));
        }

        static void AddCircle()
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Radio: ");
            double radio = double.Parse(Console.ReadLine());

            figures.Add(new Circle(name, radio));
        }

        static void AddTriangle()
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Base: ");
            double baseT = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double heightT = double.Parse(Console.ReadLine());

            figures.Add(new Triangle(name, baseT, heightT));
        }

        static void ShowFigure()
        {
            Console.WriteLine("\n--- FIGURAS CREADAS ---");
            foreach (var figura in figures)
            {
                Console.WriteLine(figura.GetInfo());
            }
        }
    }
}

