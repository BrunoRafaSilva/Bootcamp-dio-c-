using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_DadosListas.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados()
        {
            int quantity = Alunos.Count;
            return quantity;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}");
            }
        }
    }
}