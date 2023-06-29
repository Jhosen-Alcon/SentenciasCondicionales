using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores lógicos
            //bool valorBooleano = (0!=5) && (8<3);
            //bool valorBooleano = (0 != 5) || (8 < 3);
            bool valorBooleano = !(0 == 5);
            Console.WriteLine(valorBooleano);
            Console.ReadKey();


            //Sentencias condicional IF
            int num1 = 11;
            int num2 = 12;
            if (num1 > num2)
            {
                Console.WriteLine("El numero" + num1 + "es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("El numero" + num2 + "es mayor que " + num1);
            }


            //Sentencia condicional switch
            int mes = 1;
            switch (mes)
            {
                case 1: Console.WriteLine("El primer mes es enero");
                    break;
                case 2: Console.WriteLine("El segundo mes es febrero");
                    break;
                default: Console.WriteLine("Mes incorrecto");
                    break;
            }
        }
    }
}
