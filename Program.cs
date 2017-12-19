using System;
using System.IO;

namespace semana2_aula3
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            string idade = Console.ReadLine();     
           //cria o arquio.csv com nome Arquivo.csv
            StreamWriter sw = new StreamWriter("Arquivo.csv",true);
            //escreve no Arquivo.csv os valores das variáveis nome e idade
            sw.WriteLine(nome + ";" + idade);
            //Fecha o arquivo. Obs. Só depois do fechamento é que os dados irão aparecer
            sw.Close();            
        }
    }
}
