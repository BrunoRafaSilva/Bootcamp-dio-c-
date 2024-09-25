using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    public class Pessoa
    {
        public required string Name { get; set; }
        public required int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
        }
    }
}