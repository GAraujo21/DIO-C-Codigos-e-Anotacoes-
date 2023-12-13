using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._Propriedades_Metodos_e_Construtores_com_Csharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuntDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; // Concatenação de String
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}"; // Interpolação de String
                Console.WriteLine(texto);
            }

            //foreach (Pessoa aluno in Alunos){
               
              //  Console.WriteLine(aluno.NomeCompleto);
            //}
        }
    }
}