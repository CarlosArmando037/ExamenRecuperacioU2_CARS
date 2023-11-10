using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionU2_CARS.Clases
{
    internal class Problema1
    {
        

        public void SumaVendedores()
        {
            int[,] arregloVendedores = { {500,3000,100,400 },
            {1000,150, 200,500},
            {250,1800,2900,300 },
            {400,130,90,2400 },
            {60,20,4000,3600 }
            };

            for (int i=0;i<arregloVendedores.GetLength(0);i++)
            {

                for (int j=0;j<arregloVendedores.GetLength(1);j++)
                {
                    Console.Write(arregloVendedores[i,j]+ " ");
                }
                Console.WriteLine();
            }

            int suma = 0;
            for (int i=0; i<arregloVendedores.GetLength(0);i++)
            {
                for (int j=0;j<arregloVendedores.GetLength(1);j++)
                {
                    //suma+= arregloVendedores
                }
            }
        }

    }
}
