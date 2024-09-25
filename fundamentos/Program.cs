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


// Pessoa pessoa = new() { Name = "João", Age = 30 };

// pessoa.Apresentar();

// Convert não dá erro com valores nulos, já o x.Parse dá erro
int a = Convert.ToInt32("10");
// int a = int.Parse("10");
int b = 20;

int inteiro = 5;
string c = inteiro.ToString();

Console.WriteLine(a + b);
Console.WriteLine(c);

string bc = "15-";
int.TryParse(bc, out int d);
Console.WriteLine(d);
