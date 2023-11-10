using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionU2_CARS.Clases
{
    internal class Problema3
    {

        public void calificaciones()
        {
            int[] arreglo = new int[10];
            Random random= new Random();

            for (int i=0;i<arreglo.Length;i++)
            {
                arreglo[i] = random.Next(11);
                Console.Write(arreglo[i]+" ");
            }
            Console.WriteLine();
            //------------------------------------------ordenar
            for (int i=0; i< arreglo.Length ;i++)
            {
                int menor = i;
                int temp = 0;
                for (int j=i+1; j < arreglo.Length;j++)
                {
                    if (arreglo[j] < arreglo[menor])
                    {
                        menor = j;
                    }
                }
                temp = arreglo[i];
                arreglo[i] = arreglo[menor];
                arreglo[menor] = temp;
                
            }
            Console.WriteLine();
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }


            Console.WriteLine("inserte el numero a buscar");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<arreglo.Length;i++)
            {
                if (busqueda == arreglo[i])
                {
                    Console.WriteLine("el numero esta en la posicion: "+i);
                    break;
                }
                else
                {
                    Console.WriteLine("no se ha encontrado el numero");
                }
                
            }
        }
    }
}
