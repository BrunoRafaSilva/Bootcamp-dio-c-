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
cursoDeIngles.ListarAlunos();
