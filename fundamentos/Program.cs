using System;
using ExemploFundamentos.Common.Models;
// using fundamentos.Models;

// const string apresentacao = "Olá, seja bem vindo!";

// const int quantidade = 1;

// const double altura = 1.80;

// const decimal preco = 1.80M;

// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("F2"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));


Pessoa pessoa = new() { Name = "João", Age = 30 };

pessoa.Apresentar();

// Convert não dá erro com valores nulos, já o x.Parse dá erro
// int a = Convert.ToInt32("10");
// // int a = int.Parse("10");
// int b = 20;

// int inteiro = 5;
// string c = inteiro.ToString();

// Console.WriteLine(a + b);
// Console.WriteLine(c);

// string bc = "15-";
// int.TryParse(bc, out int d);
// Console.WriteLine(d);


//switch case

// Console.WriteLine("Digite uma letra");
// string letter = Console.ReadLine();



Calculadora calc = new();
calc.Somar(10, 20); 
calc.Subtrair(10, 20);
calc.Multiplicar(10, 20);
calc.Dividir(40, 2);
calc.Potencia(2, 3);

string opcao;
///

while (true)
{

    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - cadastrar cliente");
    Console.WriteLine("2 - buscar clientes");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando cliente...\n");
            break;
        case "2":
            Console.WriteLine("Buscando clientes...\n");
            break;
        case "3":
            Console.WriteLine("Apagando cliente...\n");
            break;
        case "4":
            Console.WriteLine("Saindo...\n");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida\n");
            break;
    }

}