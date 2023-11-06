using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();  // Crea una instancia de BinaryTree.

            while (true)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Agregar un número");
                Console.WriteLine("2. Buscar un número");
                Console.WriteLine("3. Eliminar un número");
                Console.WriteLine("4. Mostrar en orden");
                Console.WriteLine("5. Salir");

                int choice = int.Parse(Console.ReadLine());  // Lee la elección del usuario.

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número que desea agregar:");
                        int numberToAdd = int.Parse(Console.ReadLine());
                        tree.Insert(numberToAdd);  // Llama a la operación de inserción.
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el número que desea buscar:");
                        int numberToSearch = int.Parse(Console.ReadLine());
                        bool found = tree.Search(numberToSearch);  // Llama a la operación de búsqueda.
                        Console.WriteLine("Número encontrado: " + found);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el número que desea eliminar:");
                        int numberToDelete = int.Parse(Console.ReadLine());
                        tree.Delete(numberToDelete);  // Llama a la operación de eliminación.
                        break;
                    case 4:
                        Console.WriteLine("Elementos en orden:");
                        tree.InOrderTraversal(tree.Root);  // Llama al recorrido inorden para mostrar los elementos.
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0);  // Termina el programa.
                        break;
                    default:
                        Console.WriteLine("Selección no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}