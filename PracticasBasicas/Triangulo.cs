using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticasBasicas
{
    /*Crear clase Triangulo de acceso publico, con las sig propiedades: (con sus getters y setters correspondientes)
    -double ladoA
    -double ladoB
    -double base
    -string tipo(esta propiedad no debe tener set)
    -double altura(esta propiedad no debe tener get ni set, ni debe encontrarse en el constructor)
    Metodos:
    construnctor vacio
    constructor definiendo propiedades y Tipo en base a los valores de sus lados
    (buscar en internet la formula para saber si un triangulo es escaleno, isosceles o equilatero)
    calcularAltura(este metodo depende del TIPO de triangulo)
    mostrarValores(este metodo debe devolver un string (cadena de caracteres) que diga "Soy un triangulo de tipo...
    " "Mis medidas son..." y concatenar sus propiedades para terminar la frase
*/
    public class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double baseT;
        private string tipo;
        private double altura;

        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double BaseT { get; set; }
        public string Tipo { get { return this.tipo;}}

        public Triangulo() { 

        }

        public Triangulo(double ladoA, double ladoB, double baseT)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.baseT = baseT;

            if (ladoA == ladoB && baseT == ladoA)
            {
                this.tipo = "equilatero";
            }else if ((ladoA == baseT && ladoA != ladoB) || (ladoA != baseT && ladoA == ladoB) || (baseT == ladoB && ladoB != ladoA))
            {
                this.tipo = "isosceles";
            }
            else
            {
                this.tipo = "escaleno";
            } 
        }

        //calcularAltura(este metodo depende del TIPO de triangulo)
        public double CalcularAltura()
        {
            double altura = 0;
            if (this.tipo == "equilatero")
            {
                double a = Math.Pow(this.ladoA, 2);
                double b = Math.Pow(this.baseT / 2, 2);
                double result = a - b;
                altura = Math.Sqrt(result);
            }
            else if (this.tipo == "isosceles")
            {
                double a = Math.Pow(this.ladoA, 2);
                double b = Math.Pow(this.baseT, 2) / 4;
                altura = Math.Sqrt(a - b);
            }
            else 
            {
                double s = (this.ladoA + this.ladoB + this.baseT) / 2;
                altura = (2 / this.baseT) * Math.Sqrt(s * (s - this.baseT) * (s - this.ladoB) * (s - this.ladoA));               
            }
            return Math.Round(altura, 3);
        }

        public string MostrarValores() 
        {
            return $"Soy un triangulo de tipo {this.tipo}, Mis medidas son lado A: {this.ladoA}. ladoB: {this.ladoB}.  Base: {this.baseT}";           
        }
    }
}
