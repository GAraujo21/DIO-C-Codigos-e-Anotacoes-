using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Propriedades_Metodos_e_Construtores_com_Csharp.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome; // validação do get e set
        private int _idade;

        public string Nome { 
            
            get => _nome.ToUpper(); // isto se chama BODY EXPRESSIONS
            // é preferivel utilizar essa maneira qnd for algo simples, algo de uma linha
            // ToUpper deixa a string em MAIUSCULO
            
            set { // aqui não cabe, pois temos um if
                if (value == ""){ // o value é um argumento(parametro) que recebe o nome que o usuario está passando
                    throw new ArgumentException ("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            get => _idade;
            set {
                if (value < 0){
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            } 
            }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}