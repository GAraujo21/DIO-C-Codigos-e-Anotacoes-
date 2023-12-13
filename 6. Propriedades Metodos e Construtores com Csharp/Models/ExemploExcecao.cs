using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Propriedades_Metodos_e_Construtores_com_Csharp.Models
{
    public class ExemploExcecao
    {
        public void Metodo1(){
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Exeção tratada." + ex.Message);
            }
            
        }

        public void Metodo2(){
            Metodo3();
        }

        public void Metodo3(){
            Metodo4();
        }   

        public void Metodo4(){
            throw new Exception("Ocorre uma exceção");
        }
    }

}