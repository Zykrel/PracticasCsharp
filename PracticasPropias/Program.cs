using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPropias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me muestre cuál de los dos números es menor
            //
            //Codigo aqui
            try
            {
                Console.WriteLine("escribir primer numero");
                string primerNumero = Console.ReadLine();
                Console.WriteLine("escribir segundo numero");
                string segundoNumero = Console.ReadLine();

                int primerNumeroConvertido = int.Parse(primerNumero);
                int segundoNumeroConvertido = int.Parse(segundoNumero);

                if (primerNumeroConvertido < segundoNumeroConvertido)
                {
                    Console.WriteLine(primerNumero + " " + "es menor a " + segundoNumero);
                }
                else
                {
                    Console.WriteLine(segundoNumero + " Es menor");
                }
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error " + e.Message);
            }

            Console.ReadLine();

        }
    }
}
