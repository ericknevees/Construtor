using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDotNet.CompetenciaUm
{
    internal class Program
    {
        //O compilado vai chegar aqui
        static void Main(string[] args)
        { // inicio de algoritimo

            //variéveis
            int notaUm;
            int notaDois;
            int notaTres;
            int notaQuatro;
            int soma;
            double media;

            //perguntas
            //a linguagem c# e case sensitive (diferencia maiúsculo de minúsculo)
            Console.WriteLine("Qual a primeira Nota");//fazer uma pergunta
            //o sinal de "=" igualdade significa atribuição,ou seja, colocar dentro da variavel um valor
            notaUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a segunda Nota");
            notaDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a terceira Nota");
            notaTres = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quarta Nota");
            notaQuatro = int.Parse(Console.ReadLine());

            soma = notaUm + notaDois + notaTres + notaQuatro;

            media = soma / 4;
            string msg;
            if (media > 5)
            {
                msg = "Aprovado";
            }

            else {
                msg = "Reprovado"; }


           Console.WriteLine($"Voce tirou: {media} e está {msg}");

            Console.ReadKey();

        }//fim do algoritimo
    }
}
