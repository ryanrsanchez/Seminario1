using System;
using System.Linq;

namespace Seminario1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int[] arr = new int[10];
            int p;

            do
            {
                Console.WriteLine("1--Insertar un elemento en lista vacia");
                Console.WriteLine("2--Insertar un elemento en la primera posicion de una lista");
                Console.WriteLine("3--Insertar un elemento en la ultima posicion de una lista");
                Console.WriteLine("4--Insertar un elemento a continuacion de uno dado");
                Console.WriteLine("5--Buscar elementos en una lista");
                Console.WriteLine("6--Eliminar el primer elemento de una lista");
                Console.WriteLine("7--Eliminar un elemento dada la posicion");
                Console.WriteLine("8--Eliminar un elemento dado");
                Console.WriteLine("Elija una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Insertar un elemento en lista vacia");
                    arr[0] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Numero insert:" + arr[0]);
                }

                if(opcion == 2)
                {
                    Console.WriteLine ("Ingrese un elemento en la posicion 0");
                    arr[0] = int.Parse(Console.ReadLine());
             
                    Console.WriteLine ("posicion 0:" + arr[0]);
                }

               

            } while (opcion != 10);

        }
        }
    
}
