using System.Globalization;
using _02_DadosListas.Models;
using Newtonsoft.Json;

Pessoa p1 = new(nome: "Bruno", sobrenome: "Silva", idade: 5);

Pessoa p2 = new(nome: "Nathalia", sobrenome: "Santos", idade: 5);

Curso cursoDeIngles = new Curso
{
    Nome = "Inglês"
};
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// MANIPULANDO VETORES
//MOEDAS
decimal valorPlaca = 2399.39M;

Console.WriteLine($"{valorPlaca:C}");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Console.WriteLine($"{valorPlaca:C}");

Console.WriteLine(valorPlaca.ToString("C", new CultureInfo("ru")));

double porcentagem = .6985;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy"));


string dataString = "2022-13-17 18:00";  //mês quebrado

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime dataConvertida);

// if (sucesso)
// {
//     Console.WriteLine(dataConvertida);
// }
// else
// {
//     Console.WriteLine("Data inválida");
// }





















// EXCEPTIONS

// try
// {
//     string caminhoAbsoluto = @"C:\Users\conta\OneDrive\Documentos\Bootcamp dio c#\02-DadosListas\Arquivos\arquivoLeitura.txt";
//     string[] linhas = File.ReadAllLines(caminhoAbsoluto);

//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");0
// }

// new ExemploExcecao().Metodo1();











// FILA

Queue<int> fila = new();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento : {fila.Dequeue()}");

foreach (var item in fila)
{
    Console.WriteLine(item);
}





// Pilha

Stack<int> pilha = new();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento : {pilha.Pop()}");

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("FINAL ====================== FINAL");






/// dicionario
/// 


Dictionary<string, string> estados = new();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("ES", "Espírito Santo");

foreach (var item in estados)
{
    Console.WriteLine(item);
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

estados.Remove("ES");
estados["SP"] = "Maceio";

foreach (var item in estados)
{
    Console.WriteLine(item);
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("=========================================================");



















// TUPLAS


(int, string, string, decimal) tupla = (1, "Bruno", "Silva", 1.80M);

ValueTuple<int, string, string, decimal> tupla2 = (1, "Bruno", "Silva", 1.80M);
var tupla3 = (1, "Bruno", "Silva", 1.80M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");



LeituraArquivo arquivo = new();

var (tutesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo(@"Arquivos\arquivoLeitura.txt");

if (tutesso)
{
    Console.WriteLine($"Quantidade de linhas: {QuantidadeLinhas}");
    foreach (var item in linhasArquivo)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Erro ao ler o arquivo");
}

Pessoa p9 = new(nome: "Bruno", sobrenome: "Silva", idade: 5);
(string nome, string sobrenome, int idade) = p9;
Console.WriteLine($"{nome} - {sobrenome} - {idade}");
















// JSON

Console.WriteLine("JSONNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");

List<Venda> listaVendas = new();

Venda venda1 = new(1, "Material de escritório", 25.00M);
Venda venda2 = new(2, "Material de limpeza", 50.00M);

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);
Console.WriteLine(serializado);

string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
Console.WriteLine(listaSerializada);