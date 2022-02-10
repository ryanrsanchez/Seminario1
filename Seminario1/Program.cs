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
                 if(opcion == 3){
                    Console.WriteLine ("Ingrese un elemento en la posicion ultima posicion:");
                    arr[9] = int.Parse(Console.ReadLine());
                    Console.WriteLine ("posicion 0:" + arr[9]);
                }

               if(opcion==4){
             Console.WriteLine ("Insertar elemento: ");
             p = int.Parse(Console.ReadLine());
            
             Console.WriteLine ("Inserte un numero: ");
             arr[p] = int.Parse(Console.ReadLine());
             
             Console.WriteLine ("posicion: " + p + " Elemento: " + arr[p]);
            }

                if (opcion == 5)
                {
                    Console.WriteLine("Buscar un elemento: ");
                    p = int.Parse(Console.ReadLine());

                    Console.WriteLine("Inserte un numero: ");
                    arr[p] = int.Parse(Console.ReadLine());

                    Console.WriteLine("posicion: " + p + " Elemento: " + arr[p]);
                }
                 if(opcion==6){
             Console.WriteLine ("Eliminar el primer elemento");
             arr = arr.Where((source, index) =>index != 0).ToArray();
             Console.WriteLine ("posicion 0: " + arr[0]);
            }
                
            } while (opcion != 10);

        }
        }
    
}
