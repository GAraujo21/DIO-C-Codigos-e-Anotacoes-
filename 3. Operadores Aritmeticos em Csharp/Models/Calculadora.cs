using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Operadores_Aritmeticos_em_Csharp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} x {y} = {x*y}");
        }
        public void Potencia(int x, int y){
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 100;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 100;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(coseno, 4)}");
        } 
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 100;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada (double x){

            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}