using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_DadosListas.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        
        private string _nome = string.Empty;
        private string _sobrenome = string.Empty;
        private int _idade = 0;

        public string Nome
        {
            private get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value.ToUpper();
            }
        }

        public string Sobrenome
        {
            private get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobrenome não pode ser vazio");
                }
                _sobrenome = value.ToUpper();
            }
        }

        public int Idade
        {
            private get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} - Idade: {_idade}");
        }


    }
}