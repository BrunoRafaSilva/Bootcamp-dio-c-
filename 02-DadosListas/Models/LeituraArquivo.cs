using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_DadosListas.Models
{
    public class LeituraArquivo
    {
        public (bool Status, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }
        }
    }
}