using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionU2_CARS.Clases
{
    internal class Problema2
    {

        public void InformacionCurp()
        {
            //string CurpObtenida = "";
            string[] arregloC = new string[18];
            string sexo = "";

            for (int i = 0; i < arregloC.Length; i++)
            {
                Console.Write($"inserte el {i+1} elemento de la CURP: ");
                arregloC[i] = Console.ReadLine();
            }

            if (arregloC[10]=="H"|| arregloC[10] == "h")
            {
                sexo = "Hombre";
            }
            else if (arregloC[10] == "M" || arregloC[10] == "m")
            {
                sexo = "Mujer";
            }
            else
            {
                Console.WriteLine("problemas en encontrar el sexo");
            }


            string dia="";
            string mes="";
            string año = "";
            for (int i = 4; i < 10;i++)
            {
                if (i == 4 || i == 5)
                {
                    año += arregloC[i];
                }
                else if (i==6||i==7)
                {
                    mes += arregloC[i];
                }
                else
                {
                    dia+= arregloC[i];
                }
            }

            int aux = int.Parse(año);
            string fecha = ""; 
            if (aux >= 23)
            {
                Console.WriteLine($"ustes es del genero {sexo} y nacio en el dia {dia} del mes {mes} y el año 19{año}");
            }
            else
            {
                Console.WriteLine($"ustes es del genero {sexo} y nacio en el dia {dia} del mes {mes} y el año 20{año}");
            }

            
        }
    }
}
