using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_DadosListas.Models
{
    public class ExemploExcecao
    {

        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception x)
            {
                Console.WriteLine("Ocorreu uma exceção!\n" + x);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("ocorreu uma exceção!");
        }
    }

}