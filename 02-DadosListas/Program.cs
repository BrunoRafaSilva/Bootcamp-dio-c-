using System.Globalization;
using _02_DadosListas.Models;

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

try
{
    string caminhoAbsoluto = @"C:\Users\conta\OneDrive\Documentos\Bootcamp dio c#\02-DadosListas\Arquivos\arquivoLeitura.txt";
    string[] linhas = File.ReadAllLines(caminhoAbsoluto);

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
}