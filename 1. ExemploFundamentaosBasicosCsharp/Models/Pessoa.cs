using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentaosBasicosCsharp.Models
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public int Idade { get; set; }

        public void Exibir(){
            Console.WriteLine($"Olá, me chamo {Name}, tenho {Idade} anos");
        }
    }
}