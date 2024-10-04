using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        ///  Método que soma dois números
        /// </summary>
        /// <param name="x">O topao</param>
        /// <param name="y">Maybe topao</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} e {y} é: {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} e {y} é: {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} e {y} é: {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} e {y} é: {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"A potência de {x} e {y} é: {resultado}");
        }
    }
}