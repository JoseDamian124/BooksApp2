using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char lectura;

            do
            {
                Console.WriteLine("[A]gregar autor | [M]odificar autor | [E]liminar autor | [V]er autor | [S]alir");
                Console.Write("SELECCIONA UNA OPCION: ");
                lectura = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (lectura)
                {
                    case 'A':
                        AddAuthor();
                        break;
                    case 'M':
                        ModifyAuthor();
                        break;
                    case 'E':
                        DeleteAuthor();
                        break;
                    case 'V':
                        ShowAuthor();
                        break;
                    case 'S':
                        Console.WriteLine("Adios. Programa finalizado");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (lectura != 'S');
            Console.WriteLine(""); 
        }

        private static void ShowAuthor()
        {
            Console.WriteLine("Mostrando autor...");
        }

        private static void DeleteAuthor()
        {
            Console.WriteLine("Autor eliminado...");
        }

        private static void ModifyAuthor()
        {
            Console.WriteLine("Autor modificdo...");
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Agregando un autor...");
        }
    }
}
