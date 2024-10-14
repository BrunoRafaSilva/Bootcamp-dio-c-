using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_DadosListas.Models
{
    public class intExtensions
    {
        public static class intExtensions
        {
            public static bool EhPar(this int numero)
            {
                return numero % 2 == 0;
            }
        }
    }
}