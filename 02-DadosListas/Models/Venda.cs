using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _02_DadosListas.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public static string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}