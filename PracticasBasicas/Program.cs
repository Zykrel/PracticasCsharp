using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBasicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo equilatero = new Triangulo(10,10,10);
            Console.WriteLine(equilatero.MostrarValores() + " Altura: " + equilatero.CalcularAltura());
            
            
            Triangulo isosceles= new Triangulo(12,8,12);
            Console.WriteLine("La altura del isosceles es : "+ isosceles.CalcularAltura() );
            
            Triangulo escaleno =new Triangulo(6, 8, 10);
            Console.WriteLine(escaleno.MostrarValores() + " Altura: " + escaleno.CalcularAltura());

            Console.ReadLine();
        }
    }
}
