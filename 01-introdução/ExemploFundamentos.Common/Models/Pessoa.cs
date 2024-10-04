using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Classe que representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
        /// <summary>
        /// Apresenta a pessoa
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
        }
    }
}